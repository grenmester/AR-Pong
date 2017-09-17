using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.VR.WSA.Input;
using UnityEngine.Windows.Speech;

public class SpawnBall : MonoBehaviour
{

    public Rigidbody projectile;
    public float z_offset;
    public float y_offset;
    public float theta;
    public float shotForce = 1000f;
    public float moveSpeed = 10f;
    private GestureRecognizer recognizer;
    KeywordRecognizer keywordRecognizer = null;
    Dictionary<string, System.Action> keywords = new Dictionary<string, System.Action>();

    void SpawnABall()
    {
        print("Spawning a ball");
        Vector3 pos = transform.position;
        pos.z += z_offset;
        pos.y += y_offset;
        // Quaternion rot = transform.rotation;
        Quaternion rot = Quaternion.identity;
        rot.x = -1 * theta;
        Rigidbody shot = Instantiate(projectile, pos, rot) as Rigidbody;
        shot.AddForce(transform.forward * shotForce);
    }

    private void Awake()
    {
        // Gesture recognition
        recognizer = new GestureRecognizer();
        recognizer.SetRecognizableGestures(GestureSettings.Tap);
        recognizer.TappedEvent += (Source, tapCount, ray) => { SpawnABall(); };
        recognizer.StartCapturingGestures();
    }

    // Use this for initialization
    void Start()
    {
        // Speech recognition
        keywords.Add("Spawn ball", () =>
        {
            SpawnABall();
        });

        // Tell the KeywordRecognizer about our keywords.
        keywordRecognizer = new KeywordRecognizer(keywords.Keys.ToArray());

        // Register a callback for the KeywordRecognizer and start recognizing!
        keywordRecognizer.OnPhraseRecognized += KeywordRecognizer_OnPhraseRecognized;
        keywordRecognizer.Start();
    }

    private void Update()
    {
        float h = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float v = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(new Vector3(h, v, 0));

        if(Input.GetButtonUp("Fire1"))
        {
            SpawnABall();
        }
    }

    private void KeywordRecognizer_OnPhraseRecognized(PhraseRecognizedEventArgs args)
    {
        System.Action keywordAction;
        if (keywords.TryGetValue(args.text, out keywordAction))
        {
            keywordAction.Invoke();
        }
    }
}
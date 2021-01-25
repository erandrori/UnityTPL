using UnityEngine;
using System.Threading;
using System.Threading.Tasks;

public class ThreadTest : MonoBehaviour
{
    void Start()
    {
        var values = new int[100000000];

        Parallel.For(0, values.Length, i =>
      {
          values[i] = i;

          if (i % 1000000 == 0)
              Debug.Log("Thread-" + Thread.CurrentThread.ManagedThreadId + " worked hard! Currently i is " + i.ToString());
      }); // Parallel.For

        Debug.Log(values[50000001]);
    }
}

using UnityEngine;
using UnityEngine.Audio;

/* ----------------------------------------
 * class to demonstrate how to transition between 
 * Audio mixer Snapshots, making a dynamic soundtrack possible
 */ 
public class SnapshotTrigger : MonoBehaviour
{
	// reference to SnapShot to be transitioned into
	public AudioMixerSnapshot snapshot;

    // Duration (in seconds) for the crossfade between snapshots
	public float crossfade;

	/* ----------------------------------------
	 * When trigger enter event, begin the crossfade
	 */
	private void OnTriggerEnter(Collider other)
	{
		// Make a transition to our 'snapshot' in 'crossfade' seconds
		snapshot.TransitionTo (crossfade);
	}
}

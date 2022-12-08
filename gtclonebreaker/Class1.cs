using GorillaLocomotion;
using MelonLoader;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
using UniverseLib.Input;

namespace gtclonebreaker
{
    public class Class1 : MelonMod
    {
        
        private LayerMask plal;
        



        public override void OnInitializeMelon()
        {
            

        }

        public override void OnUpdate()
        {
            plal = Player.Instance.locomotionEnabledLayers;
            var h = GameObject.Find("pls");
            if (InputManager.GetKey(KeyCode.Q))
            {
                Player.Instance.jumpMultiplier += 1;
                Player.Instance.maxJumpSpeed = 9999999999999999999;
            }
            if (InputManager.GetKey(KeyCode.E))
            {
                Player.Instance.jumpMultiplier += 5;
                Player.Instance.maxJumpSpeed = 9999999999999999999;
            }
            if (InputManager.GetKey(KeyCode.W))
            {
                Player.Instance.jumpMultiplier -= 1;
                Player.Instance.maxJumpSpeed = 9999999999999999999;
            }
            if (InputManager.GetKey(KeyCode.A))
            {
                Player.Instance.jumpMultiplier = 1.8f;
                Player.Instance.maxJumpSpeed = 9999999999999999999;
            }
            if (InputManager.GetKey(KeyCode.Backspace))
            {
                Player.Instance.jumpMultiplier = 1.1f;
                Player.Instance.maxJumpSpeed = 6.1f;
            }
            if (InputManager.GetKey(KeyCode.V))
            {


                Player.Instance.GetComponent<Rigidbody>().isKinematic = true;
                Player.Instance.transform.position = Player.Instance.transform.position + Camera.current.transform.forward;
                Player.Instance.bodyCollider.enabled = false;
                Player.Instance.headCollider.enabled = false;
                
                Player.Instance.locomotionEnabledLayers = 0;
            }
            else
            {
                Player.Instance.bodyCollider.enabled = true;
                Player.Instance.headCollider.enabled = true;
                Player.Instance.locomotionEnabledLayers = plal;
                Player.Instance.enabled = true;
                Player.Instance.GetComponent<Rigidbody>().isKinematic = false;

            }
            Player.Instance.locomotionEnabledLayers = plal;
            if (InputManager.GetKey(KeyCode.C))
            {

                GameObject.CreatePrimitive(PrimitiveType.Capsule).AddComponent<Rigidbody>().transform.position = Player.Instance.transform.position;

            }
            if (InputManager.GetKeyDown(KeyCode.R))
            {

                var plane = GameObject.CreatePrimitive(PrimitiveType.Plane).AddComponent<Rigidbody>();
                plane.isKinematic = true;
                plane.MovePosition(new Vector3(Player.Instance.rightHandFollower.transform.position.x, Player.Instance.rightHandFollower.transform.position.y - 0.2f, Player.Instance.rightHandFollower.transform.position.z));
                plane.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
            }
            if (InputManager.GetKeyDown(KeyCode.L))
            {

                var plane = GameObject.CreatePrimitive(PrimitiveType.Plane).AddComponent<Rigidbody>();
                plane.isKinematic = true;
                plane.MovePosition(new Vector3(Player.Instance.rightHandFollower.transform.position.x, Player.Instance.rightHandFollower.transform.position.y - 0.2f, Player.Instance.rightHandFollower.transform.position.z));
                plane.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
            }

        }
        
    }

     

}

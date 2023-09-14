using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LEVELMANAGE : MonoBehaviour
{
   public static LEVELMANAGE main;

   public Transform startpoint;
   public Transform[] path;

   private void Awake()
   {
    main = this;
   }
}

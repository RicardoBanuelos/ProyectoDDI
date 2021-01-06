using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Command : MonoBehaviour
{
    private string command;

    public Command(string command)
    {
        this.command = command;
    }

    public void Execute()
    {
        if(command.Equals("Canaan"))
        {
            GameObject gameObject = GameObject.FindWithTag("kanan");
            if(gameObject!=null)
                gameObject.GetComponent<AudioPlayer>().playAudio();
        }
        else if(command.Equals("Yoda") || command.Equals("iota") || command.Equals("yeah"))
        {
            GameObject gameObject = GameObject.FindWithTag("yoda");
            if(gameObject != null)
                gameObject.GetComponent<AudioPlayer>().playAudio();
        }
        else if(command.Equals("tie fighter") || command.Equals("hi"))
        {
            GameObject gameObject = GameObject.FindWithTag("tie");
            if(gameObject != null)
                gameObject.GetComponent<AudioPlayer>().playAudio();
        }
        else if(command.Equals("R. 2 D. 2"))
        {
            GameObject gameObject = GameObject.FindWithTag("r2d2");
            if(gameObject != null)
                gameObject.GetComponent<AudioPlayer>().playAudio();
        }
        else if(command.Equals("Darth maul"))
        {
            GameObject gameObject = GameObject.FindWithTag("maul");
            if(gameObject != null)
                gameObject.GetComponent<AudioPlayer>().playAudio();
        }
        else if(command.Equals("Luke sky Walker") || command.Equals("Luke Skywalker"))
        {
            GameObject gameObject = GameObject.FindWithTag("luke");
            if(gameObject != null)
                gameObject.GetComponent<AudioPlayer>().playAudio();
        }
        else if(command.Equals("clone trooper") || command.Equals("clone"))
        {
            GameObject gameObject = GameObject.FindWithTag("clone");
            if(gameObject != null)
                gameObject.GetComponent<AudioPlayer>().playAudio();
        }
        else if(command.Equals("C. 3 PO"))
        {
            GameObject gameObject = GameObject.FindWithTag("c3po");
            if(gameObject != null)
                gameObject.GetComponent<AudioPlayer>().playAudio();
        }
        else if(command.Equals("sep") || command.Equals("sept"))
        {
            GameObject gameObject = GameObject.FindWithTag("zeb");
            if(gameObject != null)
                gameObject.GetComponent<AudioPlayer>().playAudio();
        }
        else if(command.Equals("battle droid") || command.Equals("droid"))
        {
            GameObject gameObject = GameObject.FindWithTag("droid");
            if(gameObject != null)
                gameObject.GetComponent<AudioPlayer>().playAudio();
        }
    }
}

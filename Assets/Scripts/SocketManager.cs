using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using UnityEngine;
using System;

public class SocketManager : MonoBehaviour
{

    private string host = "127.0.0.1";
    private int port = 10000;
    private Socket client;

    SocketManager()
    {
        client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        Debug.Log("create new client" + client);
    }


    // Start is called before the first frame update
  /*  void Start()
    {
*//*        client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);*//*

        try
        {
            client.Connect(new IPEndPoint(IPAddress.Parse(host), port));

            Debug.Log("server connected");
        } catch (Exception e)
        {
            Debug.Log(e.Message);
        }
    }*/

    public void SendData(string message)
    {
        try
        {
            byte[] data = Encoding.UTF8.GetBytes(message);
            client.Send(data, data.Length, new IPEndPoint(IPAddress.Parse(host), port));
        } catch (Exception e)
        {
            print(e.Message);
        }
    }

    // Update is called once per frame
    void Update()
    {
        client = new UdpClient();

        try
        {
            client.Connect(new IPEndPoint(IPAddress.Parse(host), port));

            Debug.Log("server connected again");

            Debug.Log("LocalEndPoint = " + client.Client.LocalEndPoint + ". RemoteEndPoint = " + client.Client.RemoteEndPoint);

            byte[] data = Encoding.UTF8.GetBytes("xfdsfsdfdsfd");
            client.Send(data, data.Length, new IPEndPoint(IPAddress.Parse(host), port));
        }
        catch (Exception e)
        {
            Debug.Log(e.Message);
        }
     

    }
}

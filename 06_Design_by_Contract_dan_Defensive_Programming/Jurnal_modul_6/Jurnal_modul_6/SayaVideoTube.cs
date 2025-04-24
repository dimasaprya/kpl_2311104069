using System;
using System.Collections.Generic;

public class SayaTubeUser
{
    // Properties
    public string Username { get; private set; }
    public List<SayaTubeVideo> uploadedVideos { get; private set; }

    // Constructor
    public SayaTubeUser(string username)
    {
        if (string.IsNullOrEmpty(username) || username.Length > 100)
        {
            throw new ArgumentException("Username tidak boleh null atau lebih dari 100 karakter.");
        }

        this.Username = username;
        this.uploadedVideos = new List<SayaTubeVideo>();
    }

    // Method untuk menambahkan video
    public void AddVideo(SayaTubeVideo video)
    {
        if (video == null)
        {
            throw new ArgumentException("Video yang ditambahkan tidak boleh null.");
        }

        if (video.playCount >= int.MaxValue)
        {
            throw new ArgumentException("Play count dari video harus kurang dari nilai integer maksimum.");
        }

        uploadedVideos.Add(video);
    }

    // Method untuk menghitung total play count dari semua video yang di-upload
    public int GetTotalVideoPlayCount()
    {
        int totalPlayCount = 0;
        foreach (var video in uploadedVideos)
        {
            totalPlayCount += video.playCount;
        }
        return totalPlayCount;
    }

    // Method untuk mencetak semua video dan play count
    public void PrintAllVideoPlaycount()
    {
        Console.WriteLine($"User: {this.Username}");
        int videoCount = 1;
        foreach (var video in uploadedVideos)
        {
            if (videoCount > 8) break; // Hanya print maksimal 8 video
            Console.WriteLine($"Video {videoCount++} judul: {video.title}");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int Puntaje = 5;
    private int Vidas = 2;
    private int Zombies = 0;
    private int VidaZombie = 2;
    private int RespawnVida =2;
    private int Llaves = 0;
    //private int VidaGanada = 0;
    // Start is called before the first frame update
    
    public void GanarPuntos() {
        Puntaje +=5;
    }

    public void Ganarllave() {
        Llaves +=1;
    }

    public void PerderPuntos() {
        Puntaje -=1;
    }

    public void MatarZombie() {
        Zombies +=1;
    }

    public void PerderVidas() {
        if(Vidas > 0)
            Vidas -= 1;
    }

    public void PerderVidasZombie() {
        if(VidaZombie > 0)
            VidaZombie -= 1;
    }

    public void GanarVidasZombie() {
        if(VidaZombie == 0)
            VidaZombie+=2;
    }

    public int GetPuntaje() {
        return Puntaje;
    }

    public int GetLlaves() {
        return Llaves;
    }

    public int GetVidas() {
        return Vidas;
    }
    public int GetVidaZombie() {
        return VidaZombie;
    }

    public int GetVidaZombieGanada() {
        return VidaZombie;
    }

    public int GetZombies() {
        return Zombies;
    }

    public int GetRespawn() {
        return RespawnVida;
    }
}

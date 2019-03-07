using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockBGM : MonoBehaviour
{
    //blockのBGM
    AudioSource blockaudio;

    //blockのBGMのON/OFF
    private bool onoff = true;

    // Start is called before the first frame update
    void Start()
    {
        this.blockaudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "BlockTag" || collision.gameObject.tag == "GroundTag") //新しくTagをblockとgroundにつけた
        {
            this.onoff = true;
        }

        if (this.onoff == true)
        {
            blockaudio.Play();
        }
        this.onoff = false;
    }
}

/*
ジャンプ状態のときにはボリュームを0にする（追加）
GetComponent<AudioSource>().volume = (isGround)? 1 : 0;
*/


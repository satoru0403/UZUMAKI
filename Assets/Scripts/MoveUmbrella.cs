using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUmbrella : MonoBehaviour
{

    //�v���C���[�I�u�W�F�N�g
    public GameObject player;
    //�e�̃v���n�u�I�u�W�F�N�g
    public GameObject unbrella;

    //��b���Ƃɒe�𔭎˂��邽�߂̂���
    private float targetTime = 2.0f;
    private float currentTime = 0f;
    private float stateTimer = 0f;

    // Update is called once per frame
    void Update()
    {
        //�X�^�[�g�܂ł̃^�C�}�[
        stateTimer += Time.deltaTime;
        //��b�o���Ƃɒe�𔭎˂���
        currentTime += Time.deltaTime;
        if(stateTimer >= 4)
        {
            if (targetTime < currentTime)
                    {
                        currentTime = 0;
                        //�G�̍��W��ϐ�pos�ɕۑ�
                        var pos = this.gameObject.transform.position;
                        //�e�̃v���n�u���쐬
                        var t = Instantiate(unbrella) as GameObject;
                        //�e�̃v���n�u�̈ʒu��G�̈ʒu�ɂ���
                        t.transform.position = pos;
                        //�G����v���C���[�Ɍ������x�N�g��������
                        //�v���C���[�̈ʒu����G�̈ʒu�i�e�̈ʒu�j������
                        Vector2 vec = player.transform.position - pos;
                        //�e��RigidBody2D�R���|�l���g��velocity�ɐ�����߂��x�N�g�������ė͂�������
                        t.GetComponent<Rigidbody2D>().velocity = vec;
                    }
                }
        }
        
}
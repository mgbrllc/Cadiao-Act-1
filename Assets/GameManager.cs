using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject Kira;
    public GameObject allKiraButtons;

    public GameObject Liam;
    public GameObject allLiamButtons;

    //KIRA HAIR
    public GameObject kiraHair_A;
    public GameObject kiraHair_B;
    public GameObject kiraHair_C;
    public GameObject kiraHair_D;
    public GameObject kiraHair_Default;
    public GameObject kiraHair_E;
    public GameObject kiraHair_F;

    // KIRA HEAD
    public GameObject kiraHead_A;
    public GameObject kiraHead_B;

    // KIRA PANTS
    public GameObject kiraPants_A;
    public GameObject kiraPants_B;

    //
    public GameObject kiraShirt;
    public GameObject kiraShoes;
    public GameObject kiraShorts;
    public GameObject kiraTankTop;


    public GameObject customize;
    public bool defaultCamera;


    

    public GameObject faceButton;
    public bool faceButtonPressed;
    public GameObject facePick;
    public GameObject bodyButton;
    public bool bodyButtonPressed;
    public GameObject bodyPick;
    public GameObject pantsButton;
    public bool pantsButtonPressed;
    public GameObject pantsPick;


    public GameObject back;

    public GameObject buttons;

    public int face = 0;
    public int body = 0;
    public int pants = 0;


    public GameObject changeGender;
    int gender = 0;

    public GameObject liamButtons;
    public GameObject liamFacePick;
    public GameObject liamBodyPick;
    public GameObject liamPantsPick;

    public int liamFace = 0;
    public int liamBody = 0;
    public int liamPants = 0;

    public GameObject liam_FaceB;
    public GameObject liam_FaceA;
    public GameObject liam_TShirt;
    public GameObject liam_Tank;
    public GameObject liam_Pants;

    // Start is called before the first frame update
    void Start()
    {
        defaultCamera = false;

        faceButtonPressed = false;
        bodyButtonPressed = false;
        pantsButtonPressed = false;



        
    }

    // Update is called once per frame
    void Update()
    {
        if (face == 0)
        {
            kiraHead_B.SetActive(true);
            kiraHead_A.SetActive(false);
        }
        else if (face == 1)
        {
            kiraHead_B.SetActive(false);
            kiraHead_A.SetActive(true);
        }

        if (body == 0)
        {
            kiraTankTop.SetActive(true);
            kiraShirt.SetActive(false);
        }
        else if (body == 1)
        {
            kiraTankTop.SetActive(false);
            kiraShirt.SetActive(true);
        }

        if (pants == 0)
        {
            kiraPants_B.SetActive(true);
            kiraPants_A.SetActive(false);
            kiraShorts.SetActive(false);
        }
        else if (pants == 1)
        {
            kiraPants_B.SetActive(false);
            kiraPants_A.SetActive(true);
            kiraShorts.SetActive(false);
        }
        else if (pants == 2)
        {
            kiraPants_B.SetActive(false);
            kiraPants_A.SetActive(false);
            kiraShorts.SetActive(true);
        }

        if (gender == 0)
        {
            Kira.SetActive(true);
            allKiraButtons.SetActive(true);
            Liam.SetActive(false);
            allLiamButtons.SetActive(false);
        }
        else if (gender == 1)
        {
            Kira.SetActive(false);
            allKiraButtons.SetActive(false);
            Liam.SetActive(true);
            allLiamButtons.SetActive(true);
        }

        if (liamFace == 0)
        {
            liam_FaceB.SetActive(true);
            liam_FaceA.SetActive(false);
        }
        else if (liamFace == 1)
        {
            liam_FaceB.SetActive(false);
            liam_FaceA.SetActive(true);
        }

        if (liamBody == 0)
        {
            liam_Tank.SetActive(false);
            liam_TShirt.SetActive(false);
        }
        else if (liamBody == 1)
        {
            liam_Tank.SetActive(true);
            liam_TShirt.SetActive(false);
        }
        else if (liamBody == 2)
        {
            liam_Tank.SetActive(false);
            liam_TShirt.SetActive(true);
        }

        if (liamPants == 0)
        {
            liam_Pants.SetActive(false);
        }
        else if (liamPants == 1)
        {
            liam_Pants.SetActive(true);
        }
    }

    public void Customize()
    {
        customize.SetActive(false);
        defaultCamera = true;
        changeGender.SetActive(true);
        
    }

    public void Back()
    {
        customize.SetActive(false);
        defaultCamera = true;
        faceButtonPressed = false;
        bodyButtonPressed = false;
        buttons.SetActive(true);
        changeGender.SetActive(true);
        back.SetActive(false);
        facePick.SetActive(false);
        bodyPick.SetActive(false);
        pantsPick.SetActive(false);

        liamButtons.SetActive(true);
        liamFacePick.SetActive(false);
        liamBodyPick.SetActive(false);
        liamPantsPick.SetActive(false);

    }

    public void Face()
    {
        buttons.SetActive(false);
        back.SetActive(true);
        facePick.SetActive(true);
        changeGender.SetActive(false);

        defaultCamera = false;
        faceButtonPressed = true;

    }

    public void Body()
    {
        buttons.SetActive(false);
        back.SetActive(true);
        bodyPick.SetActive(true);
        defaultCamera = false;
        bodyButtonPressed = true;
        changeGender.SetActive(false);

    }
    
    public void Pants()
    {
        buttons.SetActive(false);
        back.SetActive(true);
        pantsPick.SetActive(true);
        defaultCamera = false;
        pantsButtonPressed = true;
        changeGender.SetActive(false);
    }

    public void FaceRight()
    {
        face++;
        if (face == 2)
        {
            face = 0;
        }
    }
    public void FaceLeft()
    {
        face--;
        if (face == -1)
        {
            face = 1;
        }
    }

    public void BodyRight()
    {
        body++;
        if (body == 2)
        {
            body = 0;
        }
    }

    public void BodyLeft()
    {
        body--;
        if (body == -1)
        {
            body = 1;
        }
    }

    public void PantsLeft()
    {
        pants--;
        if (pants == -1)
        {
            pants = 2;
        }
    }    
    public void PantsRight()
    {
        pants++;
        if (pants == 3)
        {
            pants = 0;
        }
    }

    public void ChangeGender()
    {
        gender++;
        if (gender == 2)
        {
            gender = 0;
        }
    }
    


    public void LiamFace()
    {
        liamButtons.SetActive(false);
        back.SetActive(true);
        liamFacePick.SetActive(true);
        changeGender.SetActive(false);

        defaultCamera = false;
        faceButtonPressed = true;
    }

    public void LiamBody()
    {
        liamButtons.SetActive(false);
        back.SetActive(true);
        liamBodyPick.SetActive(true);
        changeGender.SetActive(false);

        defaultCamera = false;
        bodyButtonPressed = true;
        
    }

    public void LiamPants()
    {
        liamButtons.SetActive(false);
        back.SetActive(true);
        liamPantsPick.SetActive(true);
        changeGender.SetActive(false);

        defaultCamera = false;
        pantsButtonPressed = true;
        
    }

    public void LiamFaceRight()
    {
        liamFace++;
        if (liamFace == 2)
        {
            liamFace = 0;
        }
    }
    public void LiamFaceLeft()
    {
        liamFace--;
        if (liamFace == -1)
        {
            liamFace = 1;
        }
    }

    public void LiamBodyRight()
    {
        liamBody++;
        if (liamBody == 3)
        {
            liamBody = 0;
        }
    }

    public void LiamBodyLeft()
    {
        liamBody--;
        if (liamBody == -1)
        {
            liamBody = 2;
        }
    }

    public void LiamPantsLeft()
    {
        liamPants--;
        if (liamPants == -1)
        {
            liamPants = 1;
        }
    }
    public void LiamPantsRight()
    {
        liamPants++;
        if (liamPants == 2)
        {
            liamPants = 0;
        }
    }
}

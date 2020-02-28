using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

//this code follows a paper storyboard
//code will be divided into sections of the storyboard

public class AniLoader : MonoBehaviour
{
    public TextMeshProUGUI title;
    //2
    public GameObject CalPoly;
    //3
    public GameObject probSolv;
    public GameObject teamBuild;
    public GameObject creativity;
    //4
    public GameObject STEMLetters;
    //5
    public GameObject STEM;
    public GameObject sci;
    public GameObject tech;
    public GameObject eng;
    public GameObject math;
    //6
    public GameObject Sbackground;
    public GameObject planets;
    public GameObject earth;
    public GameObject plants;
    //7
    public GameObject Tbackground;
    public GameObject TText;
    public GameObject computer;
    //8
    public GameObject Ebackground;
    public GameObject bridge;
    public GameObject robot;
    public GameObject car;
    //9
    public GameObject Mbackground;
    //10
    public GameObject DidUCode;
    //11
    public GameObject partOfImage;
    public GameObject coding;
    public GameObject partOf;
    public GameObject comProg;
    //12
    public GameObject programmer;
    public GameObject progTxt;
    public GameObject taskTxt;
    //13
    public GameObject youtube;
    public GameObject videogames;
    public GameObject linesCode;
    //14
    public GameObject plug;
    public GameObject battery;
    public GameObject useCode;
    //15
    public GameObject phone;
    public GameObject watch;
    public GameObject carItem;
    //16
    public GameObject codeTxt;
    public GameObject Instru;
    public GameObject comp;
    //17
    public GameObject cake;
    public GameObject recipe;
    public GameObject ingred;
    //18
    public GameObject blckCode;
    public GameObject robots;
    //19
    public GameObject characters;
    public GameObject bye;

    // Start is called before the first frame update
    void Start()
    {
        title.gameObject.SetActive(true);
        //STEMLetters.gameObject.SetActive(false);
        StartCoroutine(TitleDelay());
    }

    void transitions_nodestroy(GameObject x, IEnumerator func)
    {
        x.gameObject.SetActive(true);
        //goes to set the other animation ready
        StartCoroutine(func);
    }


//----- storyboard #1 -----
    IEnumerator TitleDelay()
    {
        yield return new WaitForSeconds(5.75f);
        title.gameObject.SetActive(false);

        //goes to the next storyboard scene #2
        transitions_nodestroy(CalPoly, CPDelay());
    }

//----- storyboard #2 -----
    IEnumerator CPDelay()
    {
        yield return new WaitForSeconds(5.75f);
        Destroy(CalPoly);
        //disactiving it causes glitching so destroying is best option

        //goes to the next storyboard scene #3
        StartCoroutine(FocusDelay());
    }

// ----- storyboard #3 -----
    IEnumerator FocusDelay()
    {
        yield return new WaitForSeconds(0.3f);
        //dont use function since 3 items
        teamBuild.gameObject.SetActive(true);
        yield return new WaitForSeconds(1f);
        probSolv.gameObject.SetActive(true);
        yield return new WaitForSeconds(1f);
        creativity.gameObject.SetActive(true);
        StartCoroutine(MoveOn());
    }

    //destory after it is displayed
    IEnumerator MoveOn()
    {
        yield return new WaitForSeconds(3.75f);
        Destroy(probSolv);
        Destroy(teamBuild);
        Destroy(creativity);
        transitions_nodestroy(STEMLetters, STEMDelay());
    }

//----- storyboard #4 -----
    IEnumerator STEMDelay()
    {
        yield return new WaitForSeconds(5f);
        STEMLetters.gameObject.SetActive(false);
        StartCoroutine(DefineDelay());
    }

//----- storyboard #5 -----
    IEnumerator DefineDelay()
    {
        STEM.gameObject.SetActive(true);
        yield return new WaitForSeconds(0.75f);
        sci.gameObject.SetActive(true);
        yield return new WaitForSeconds(1f);
        tech.gameObject.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        eng.gameObject.SetActive(true);
        yield return new WaitForSeconds(1.2f);
        math.gameObject.SetActive(true);

        //go destroy these objects and continue on to next board
        StartCoroutine(MoveOn2());

    }

    //destory after it is displayed
    IEnumerator MoveOn2()
    {
        yield return new WaitForSeconds(2f);
        Destroy(STEM);
        Destroy(sci);
        Destroy(tech);
        Destroy(eng);
        Destroy(math);

        //go to next board
        StartCoroutine(Science());
    }

//----- storyboard #6 -----
    IEnumerator Science()
    {
        Sbackground.gameObject.SetActive(true);
        yield return new WaitForSeconds(3f);
        planets.gameObject.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        earth.gameObject.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        plants.gameObject.SetActive(true);

        yield return new WaitForSeconds(3.5f);

        //go to next board
        StartCoroutine(Technology());
    }

//----- storyboard #7 -----
    IEnumerator Technology()
    {
        //deactivite the previous
        Sbackground.gameObject.SetActive(false);
        Destroy(planets);
        Destroy(earth);
        Destroy(plants);

        //do background animation
        TText.gameObject.SetActive(true);
        Tbackground.gameObject.SetActive(true);
        
        //to display the moving computer text animation
        yield return new WaitForSeconds(1f);
        StartCoroutine(TechnologyTrans());

    }

    //manually doing the backgroun animation
    IEnumerator TechnologyTrans()
    {
        computer.gameObject.SetActive(true);
        yield return new WaitForSeconds(2f);
        StartCoroutine(TechnologyTrans2());
    }
    IEnumerator TechnologyTrans2()
    {
        computer.gameObject.SetActive(false);
        yield return new WaitForSeconds(2f);
        StartCoroutine(TechnologyTrans3());
    }
    IEnumerator TechnologyTrans3()
    {
        computer.gameObject.SetActive(true);
        yield return new WaitForSeconds(2f);
        StartCoroutine(TechnologyTrans4());
    }
    IEnumerator TechnologyTrans4()
    {
        computer.gameObject.SetActive(false);
        yield return new WaitForSeconds(0.0001f);

        //go to next board
        StartCoroutine(Engineering());
    }

//----- storyboard #8 -----
    IEnumerator Engineering()
    {
        //destroy the previous so there is no glitching 
        Destroy(TText);
        Destroy(Tbackground);
        Destroy(computer);
        //start new
        Ebackground.gameObject.SetActive(true);
        yield return new WaitForSeconds(2.45f);
        bridge.gameObject.SetActive(true);
        yield return new WaitForSeconds(1f);
        robot.gameObject.SetActive(true);
        yield return new WaitForSeconds(1f);
        car.gameObject.SetActive(true);
        yield return new WaitForSeconds(1.15f);

        //go to next board
        StartCoroutine(Mathematics());
    }

//----- storyboard #9 -----
    IEnumerator Mathematics()
    {
        //deactivite the previous
        Ebackground.gameObject.SetActive(false);
        Destroy(bridge);
        Destroy(robot);
        Destroy(car);

        Mbackground.gameObject.SetActive(true);
        yield return new WaitForSeconds(8f);

        //go to next board
        StartCoroutine(DidUknow());
    }

//----- storyboard #10 -----
    IEnumerator DidUknow()
    {
        //deactivite the previous
        Mbackground.gameObject.SetActive(false);
        DidUCode.gameObject.SetActive(true);
        yield return new WaitForSeconds(2.75f);

        //go to next board
        StartCoroutine(PartOFCP());
    }

//----- storyboard #11 -----
    IEnumerator PartOFCP()
    {
        //deactivite the previous
        DidUCode.gameObject.SetActive(false);
        partOfImage.gameObject.SetActive(true);
        yield return new WaitForSeconds(1.25f);
        coding.gameObject.SetActive(true);
        yield return new WaitForSeconds(0.75f);
        partOf.gameObject.SetActive(true);
        yield return new WaitForSeconds(0.75f);
        comProg.gameObject.SetActive(true);
        yield return new WaitForSeconds(3f);

        //go to next boards
        StartCoroutine(CreativeProc());
    }

//----- storyboard #12 -----
    IEnumerator CreativeProc()
    {
        //deactivite the previous
        Destroy(partOfImage);
        Destroy(coding);
        Destroy(partOf);
        Destroy(comProg);

        //start new board
        programmer.gameObject.SetActive(true);
        yield return new WaitForSeconds(0.75f);
        progTxt.gameObject.SetActive(true);
        yield return new WaitForSeconds(1.2f);
        taskTxt.gameObject.SetActive(true);
        yield return new WaitForSeconds(3.25f);
  
        //go to next boards
        StartCoroutine(LinesOfCode());
    }

//----- storyboard #13 -----
    IEnumerator LinesOfCode()
    {
        //deactivite the previous
        Destroy(programmer);
        Destroy(progTxt);
        Destroy(taskTxt);

        //start new board
        youtube.gameObject.SetActive(true);
        yield return new WaitForSeconds(1f);
        videogames.gameObject.SetActive(true);
        yield return new WaitForSeconds(3.65f);
        linesCode.gameObject.SetActive(true);
        yield return new WaitForSeconds(4f);

        //go to next boards
        StartCoroutine(BattNPlug());
    }

//----- storyboard #14 -----
    IEnumerator BattNPlug()
    {
        //deactivite the previous
        Destroy(youtube);
        Destroy(videogames);
        Destroy(linesCode);

        //start new board
        plug.gameObject.SetActive(true);
        yield return new WaitForSeconds(0.90f);
        battery.gameObject.SetActive(true);
        yield return new WaitForSeconds(1f);
        useCode.gameObject.SetActive(true);
        yield return new WaitForSeconds(2.75f);
        //go to next boards
        StartCoroutine(Items());
    }

//----- storyboard #15 -----
    IEnumerator Items()
    {
        //deactivite the previous
        Destroy(plug);
        Destroy(battery);
        Destroy(useCode);

        //start new board
        phone.gameObject.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        watch.gameObject.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        carItem.gameObject.SetActive(true);
        yield return new WaitForSeconds(4f);

        //go to next boards
        StartCoroutine(instructions());
    }

//----- storyboard #16 -----
    IEnumerator instructions()
    {
        //deactivite the previous
        Destroy(phone);
        Destroy(watch);
        Destroy(carItem);

        //start new board
        codeTxt.gameObject.SetActive(true);
        yield return new WaitForSeconds(0.75f);
        Instru.gameObject.SetActive(true);
        yield return new WaitForSeconds(0.75f);
        comp.gameObject.SetActive(true);
        yield return new WaitForSeconds(2.25f);

        //go to next boards
        StartCoroutine(RecipeEx());
    }

//----- storyboard #17 -----
    IEnumerator RecipeEx()
    {
        //deactivite the previous
        Destroy(codeTxt);
        Destroy(Instru);
        Destroy(comp);

        //start new board
        yield return new WaitForSeconds(1f);
        recipe.gameObject.SetActive(true);
        yield return new WaitForSeconds(4.25f);
        ingred.gameObject.SetActive(true);
        yield return new WaitForSeconds(2f);
        cake.gameObject.SetActive(true);
        yield return new WaitForSeconds(2f);

        //go to next boards
        StartCoroutine(CueRobots());
    }

    //----- storyboard #18 -----
    IEnumerator CueRobots()
    {
        //deactivite the previous
        Destroy(cake);
        Destroy(recipe);
        Destroy(ingred);

        yield return new WaitForSeconds(0.5f);
        //start new board
        blckCode.gameObject.SetActive(true);
        yield return new WaitForSeconds(1.5f);
        robots.gameObject.SetActive(true);
        yield return new WaitForSeconds(4f);

        //go to next boards
        StartCoroutine(End());
    }

    //----- storyboard #19 -----
    IEnumerator End()
    {
        //deactivite the previous
        Destroy(blckCode);
        Destroy(robots);
        //start new board
        characters.gameObject.SetActive(true);
        yield return new WaitForSeconds(1.75f);
        bye.gameObject.SetActive(true);
        yield return new WaitForSeconds(10f);

        //load menu again
        SceneManager.LoadScene("StartPage");
    }

}

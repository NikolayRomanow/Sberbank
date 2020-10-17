using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OculusSampleFramework;
using TMPro;

public class InformationOfCoin : MonoBehaviour
{
    OVRGrabber grabber;
    OVRGrabbable grabbable;

    public Animator InfoAnim;

    public TextMeshProUGUI Country, Metal, Quality, Nominal, Mass;

    private void Awake()
    {
        grabber = this.GetComponent<DistanceGrabber>();
    }

    private void Update()
    {
        grabbable = grabber.grabbedObject;

        if (grabbable == null)
        {
            InfoAnim.Play("AnimInfoOffRight");
        }

        if (grabbable.name == "CoinRazvitie")
        {
            InfoAnim.Play("AnimInfoRight");
            Country.text = "СТРАНА: РОССИЯ";
            Metal.text = "МЕТАЛЛ: СЕРЕБРО";
            Quality.text = "КАЧЕСТВО: PR";
            Nominal.text = "НОМИНАЛ: Р3";
            Mass.text = "МАССА ДРАГ. МЕТАЛЛА: 31.1Г";
        }

        if (grabbable.name == "CoinTorrentino")
        {
            InfoAnim.Play("AnimInfoRight");
            Country.text = "СТРАНА: РОССИЯ";
            Metal.text = "МЕТАЛЛ: СЕРЕБРО";
            Quality.text = "КАЧЕСТВО: PR";
            Nominal.text = "НОМИНАЛ: 25Р";
            Mass.text = "МАССА ДРАГ. МЕТАЛЛА: 155.5Г";
        }

        if (grabbable.name == "CoinExpeditsiya")
        {
            InfoAnim.Play("AnimInfoRight");
            Country.text = "СТРАНА: РОССИЯ";
            Metal.text = "МЕТАЛЛ: СЕРЕБРО";
            Quality.text = "КАЧЕСТВО: PR";
            Nominal.text = "НОМИНАЛ: 3Р";
            Mass.text = "МАССА ДРАГ. МЕТАЛЛА: 31.1Г";
        }

        if (grabbable.name == "CoinMtsiry")
        {
            InfoAnim.Play("AnimInfoRight");
            Country.text = "СТРАНА: РОССИЯ";
            Metal.text = "МЕТАЛЛ: СЕРЕБРО";
            Quality.text = "КАЧЕСТВО: PR";
            Nominal.text = "НОМИНАЛ: 25Р";
            Mass.text = "МАССА ДРАГ. МЕТАЛЛА: 155.5Г";
        }

        if (grabbable.name == "CoinSoljhenitsyn")
        {
            InfoAnim.Play("AnimInfoRight");
            Country.text = "СТРАНА: РОССИЯ";
            Metal.text = "МЕТАЛЛ: СЕРЕБРО";
            Quality.text = "КАЧЕСТВО: PR";
            Nominal.text = "НОМИНАЛ: 2Р";
            Mass.text = "МАССА ДРАГ. МЕТАЛЛА: 15.55Г";
        }

        if (grabbable.name == "CoinZheltovodskiy")
        {
            InfoAnim.Play("AnimInfoRight");
            Country.text = "СТРАНА: РОССИЯ";
            Metal.text = "МЕТАЛЛ: СЕРЕБРО";
            Quality.text = "КАЧЕСТВО: PR";
            Nominal.text = "НОМИНАЛ: 25Р";
            Mass.text = "МАССА ДРАГ. МЕТАЛЛА: 155.5Г";
        }

        if (grabbable.name == "CoinArkhangelskoe")
        {
            InfoAnim.Play("AnimInfoRight");
            Country.text = "СТРАНА: РОССИЯ";
            Metal.text = "МЕТАЛЛ: СЕРЕБРО";
            Quality.text = "КАЧЕСТВО: PR";
            Nominal.text = "НОМИНАЛ: 25Р";
            Mass.text = "МАССА ДРАГ. МЕТАЛЛА: 155.5Г";
        }

        if (grabbable.name == "CoinKislovodsk")
        {
            InfoAnim.Play("AnimInfoRight");
            Country.text = "СТРАНА: РОССИЯ";
            Metal.text = "МЕТАЛЛ: СЕРЕБРО";
            Quality.text = "КАЧЕСТВО: PR";
            Nominal.text = "НОМИНАЛ: 3Р";
            Mass.text = "МАССА ДРАГ. МЕТАЛЛА: 31.1Г";
        }

        if (grabbable.name == "CoinBianky")
        {
            InfoAnim.Play("AnimInfoRight");
            Country.text = "СТРАНА: РОССИЯ";
            Metal.text = "МЕТАЛЛ: СЕРЕБРО";
            Quality.text = "КАЧЕСТВО: PR";
            Nominal.text = "НОМИНАЛ: 2Р";
            Mass.text = "МАССА ДРАГ. МЕТАЛЛА: 15.55Г";
        }

        if (grabbable.name == "CoinOhotnikZmeya")
        {
            InfoAnim.Play("AnimInfoRight");
            Country.text = "СТРАНА: РОССИЯ";
            Metal.text = "МЕТАЛЛ: СЕРЕБРО";
            Quality.text = "КАЧЕСТВО: PR";
            Nominal.text = "НОМИНАЛ: 3Р";
            Mass.text = "МАССА ДРАГ. МЕТАЛЛА: 31.1Г";
        }

        if (grabbable.name == "CoinMustayKarim")
        {
            InfoAnim.Play("AnimInfoRight");
            Country.text = "СТРАНА: РОССИЯ";
            Metal.text = "МЕТАЛЛ: СЕРЕБРО";
            Quality.text = "КАЧЕСТВО: PR";
            Nominal.text = "НОМИНАЛ: 2Р";
            Mass.text = "МАССА ДРАГ. МЕТАЛЛА: 15.55Г";
        }

        if (grabbable.name == "CoinRGO")
        {
            InfoAnim.Play("AnimInfoRight");
            Country.text = "СТРАНА: РОССИЯ";
            Metal.text = "МЕТАЛЛ: СЕРЕБРО";
            Quality.text = "КАЧЕСТВО: PR";
            Nominal.text = "НОМИНАЛ: 1Р";
            Mass.text = "МАССА ДРАГ. МЕТАЛЛА: 7.78Г";
        }

        if (grabbable.name == "CoinStabilnost")
        {
            InfoAnim.Play("AnimInfoRight");
            Country.text = "СТРАНА: РОССИЯ";
            Metal.text = "МЕТАЛЛ: СЕРЕБРО";
            Quality.text = "КАЧЕСТВО: PR";
            Nominal.text = "НОМИНАЛ: 3Р";
            Mass.text = "МАССА ДРАГ. МЕТАЛЛА: 31.1Г";
        }

        if (grabbable.name == "CoinInnovatsionost")
        {
            InfoAnim.Play("AnimInfoRight");
            Country.text = "СТРАНА: РОССИЯ";
            Metal.text = "МЕТАЛЛ: СЕРЕБРО";
            Quality.text = "КАЧЕСТВО: PR";
            Nominal.text = "НОМИНАЛ: 3Р";
            Mass.text = "МАССА ДРАГ. МЕТАЛЛА: 31.1Г";
        }

        if (grabbable.name == "CoinPodedonosec")
        {
            InfoAnim.Play("AnimInfoRight");
            Country.text = "СТРАНА: РОССИЯ";
            Metal.text = "МЕТАЛЛ: СЕРЕБРО";
            Quality.text = "КАЧЕСТВО: UC";
            Nominal.text = "НОМИНАЛ: 3Р";
            Mass.text = "МАССА ДРАГ. МЕТАЛЛА: 31.1Г";
        }

        if (grabbable.name == "CoinVolk")
        {
            InfoAnim.Play("AnimInfoRight");
            Country.text = "СТРАНА: РОССИЯ";
            Metal.text = "МЕТАЛЛ: СЕРЕБРО";
            Quality.text = "КАЧЕСТВО: PR";
            Nominal.text = "НОМИНАЛ: 3Р";
            Mass.text = "МАССА ДРАГ. МЕТАЛЛА: 31.1Г";
        }
    }

}

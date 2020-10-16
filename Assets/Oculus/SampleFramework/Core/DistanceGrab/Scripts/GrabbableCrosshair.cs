/************************************************************************************

Copyright (c) Facebook Technologies, LLC and its affiliates. All rights reserved.  

See SampleFramework license.txt for license terms.  Unless required by applicable law 
or agreed to in writing, the sample code is provided “AS IS” WITHOUT WARRANTIES OR 
CONDITIONS OF ANY KIND, either express or implied.  See the license for specific 
language governing permissions and limitations under the license.

************************************************************************************/
using UnityEngine;
using System.Collections;


public class GrabbableCrosshair : MonoBehaviour
{
    public enum CrosshairState { Disabled, Enabled, Targeted }

    CrosshairState m_state = CrosshairState.Disabled;
    Transform m_centerEyeAnchor;

    [SerializeField]
    GameObject m_targetedCrosshair = null;
    [SerializeField]
    GameObject m_enabledCrosshair = null;
    public short canBe = 3;
    private Rigidbody rb;
    private void Start()
    {
        m_centerEyeAnchor = GameObject.Find("CenterEyeAnchor").transform;
        rb = this.gameObject.GetComponentInParent<Rigidbody>();
    }

    public void SetState(CrosshairState cs)
    {
        m_state = cs;
        if (cs == CrosshairState.Disabled)
        {
            //m_targetedCrosshair.SetActive(false);
            //m_enabledCrosshair.SetActive(false);
        }
        else if (cs == CrosshairState.Enabled)
        {
            canBe = 2;
            //m_targetedCrosshair.SetActive(false);
            //m_enabledCrosshair.SetActive(true);
        }
        else if (cs == CrosshairState.Targeted)
        {
            canBe = 1;
            //m_targetedCrosshair.SetActive(true);
            //m_enabledCrosshair.SetActive(false);
        }
    }

    public void MovementCoin(Transform coin)
    {
        coin.transform.position = Vector3.MoveTowards(coin.transform.position, new Vector3(coin.transform.position.x, coin.transform.position.y, 0.9f), Time.deltaTime / 10);
        if (coin.transform.position.z == 0.9f)
        {
            canBe = -1;
        }   
    }

    public void MovementCoinReturn(Transform coin)
    {
        coin.transform.position = Vector3.MoveTowards(coin.transform.position, new Vector3(coin.transform.position.x, coin.transform.position.y, 0.8776414f), Time.deltaTime / 10);
        if (coin.transform.position.z == 0.8776414f)
        {
            canBe = -1;
        }
    }

    private void Update()
    {
        if (m_state != CrosshairState.Disabled)
        {
            transform.LookAt(m_centerEyeAnchor);
        }
        if (canBe == 1)
            MovementCoin(this.transform.parent);
        if (canBe == 2)
            MovementCoinReturn(this.transform.parent);
    }
}

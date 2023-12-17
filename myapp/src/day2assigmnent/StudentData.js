import React from "react";
import EduDetails from "./EduDetails";

export default class StudentData extends React.Component
{    constructor()
    {
        super()
        this.state={flag:false}
    }
    render()
    {        return(
            <div>
                <p>Name :  Sourabh
                   </p><p>Dob : 20-April-2002
                </p>
                <p>email:slowanshi21@gmail.com</p>
                Edu Details :<input type="checkbox" 
                            onClick={(e)=>{
                                this.setState({flag:e.target.checked})

                            }}
                            />
            
             {this.state.flag && <EduDetails></EduDetails>}

            </div>
        )
    }
}



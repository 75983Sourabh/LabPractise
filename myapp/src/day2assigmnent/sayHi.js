import { useState } from "react"

export default function SayHi()
{
    
    let [msg,setmsg] =useState("") 
    function handler()
    {
       
        setmsg("hi")
        
        console.log("msg =",msg)
    }
    return(
        <>
        <input 
           type="button" 
           value="say hi"
           onClick={handler} 
        />
      
        <p>{msg}</p>
        </>
    )
}
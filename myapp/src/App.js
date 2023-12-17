
import './App.css';


import Maths from "./components/maths";
import Welcome, { Greeting } from "./components/welcome";
import Total from "./components/total";

import ICard from "./components/Icard";


function App() {
 
    let x =<p>Hello</p>
    console.log("Type of x",typeof(x))
    let arr=[12,13,10,20]
    let obj={name:"Sourabh",dob:"20-04-2001",phone:"9192939495"}



    return (
      <>
      <p>Hello</p>

      <Greeting>Sourabh</Greeting>
      <ICard obj={obj}></ICard>
      <Total nums={arr}></Total>
      <Maths num1={30} num2={1.4} op={"*"}></Maths>
      <Maths num1={30} num2={100} op={"*"}></Maths>
      <Maths num1={1.9} num2={1.4} op={"-"}></Maths>
      <Maths num1={300} num2={3} op={"/"}></Maths>
      
      
      
      </>
  );
}

export default App;

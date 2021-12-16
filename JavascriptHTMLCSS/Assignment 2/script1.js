/*
screen input

button functionaliy 
    function buttons
    number buttons
    clear button
    equals button
    delete button
*/

var screen = document.getElementById('screen');

function numberButton(value)
{
  if (!flag)
  {
    if (screen.innerHTML == 0)
    {
    screen.innerHTML = value
    }
    else
    {
    screen.innerHTML += value
    }
  }
  else
  {
    screen.innerHTML = value
    flag = false
  }
}

function calculate(string)
{
  firstOperand = screen.innerHTML
  operator = string
  flag = true
}

var flag = false

function equals(string)
{
  secondOperand = screen.innerHTML
  if (operator == "+")
  {
    screen.innerHTML = parseInt(firstOperand) + parseInt(secondOperand)
  }
  else if (operator == "-")
  {
    screen.innerHTML = parseInt(firstOperand) - parseInt(secondOperand)
  }
  else if (operator == "/")
  {
    screen.innerHTML = parseInt(firstOperand) / parseInt(secondOperand)
  }
  else if (operator == "*")
  {
    screen.innerHTML = parseInt(firstOperand) * parseInt(secondOperand)
  }
}

function clearNumber()
{
  screen.innerHTML = 0
}

function deleteNumber()
{
  screen.innerHTML = screen.innerHTML.slice(0, screen.innerHTML.length - 1)
  if (screen.innerHTML == 0)
  {
    screen.innerHTML = 0
  } 
}


console.log();
var firstOperand  
var secondOperan 
var operator
var clear


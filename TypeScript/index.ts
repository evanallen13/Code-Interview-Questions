
function Main(A: number[]){

  if(A.length <= 1) return true;

  enum Monotone{
    "Increase",
    "Decrease",
    "Equal"
  }

  let monotone: Monotone;
  let currMono: Monotone;

  for(let i = 1; i <= A.length-1; i++){
    let prev = A[i - 1];
    let curr = A[i];
    console.log(monotone);
    if(prev < curr)
      currMono = Monotone.Increase
    else if(prev > curr)
      currMono = Monotone.Decrease
    else 
      continue;

    if(currMono !== monotone && monotone !== undefined)
      return false;

    monotone = currMono;
  }

  return true;
}

let arr: number[] = [2,2,2,1,4,5];
let res = Main(arr);
console.log(res);

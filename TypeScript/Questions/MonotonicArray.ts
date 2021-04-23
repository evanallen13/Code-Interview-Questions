function isMonotonic(A: number[]): boolean {
  if (A.length <= 1) return true;

  enum Monotone {
    "Increase",
    "Decrease",
  }

  let monotone: Monotone;
  let currMono: Monotone;

  for (let i = 1; i <= A.length - 1; i++) {
    let prev = A[i - 1];
    let curr = A[i];

    if (prev < curr) currMono = Monotone.Increase;
    else if (prev > curr) currMono = Monotone.Decrease;
    else continue;

    if (currMono !== monotone && monotone !== undefined) return false;

    monotone = currMono;
  }

  return true;
}

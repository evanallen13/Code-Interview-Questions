export function monotoneIncreasingDigits(N: number): number {
  for (let i = N; i >= 0; i--) {
    if (isMonotonic(i)) return i;
  }
  return -1;
}

function isMonotonic(x: number): boolean {
  let A = x.toString().split("");
  if (A.length <= 1) return true;

  let l: number = 1;
  let r: number = A.length - 1;

  while (l <= r) {
    // leftMinus > left
    if (Number(A[l - 1]) > Number(A[l])) return false;
    // rightMinus > right
    if (Number(A[r - 1]) > Number(A[r])) return false;

    r--;
    l++;
  }

  return true;
}

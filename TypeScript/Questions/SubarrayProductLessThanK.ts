function numSubarrayProductLessThanK(nums: number[], k: number): number {
  if (k <= 1) return 0;
  let result = 0;

  for (let l = 0; l < nums.length; l++) {
    let curr = 1;
    let r = l;
    while (curr < k) {
      const num = nums[r];
      curr *= num;    
      r++;
      if(curr < k)
         result++; 
    }
  }
  return result;
}

export default numSubarrayProductLessThanK;

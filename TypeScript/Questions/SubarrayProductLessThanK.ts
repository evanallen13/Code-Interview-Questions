function numSubarrayProductLessThanK(nums: number[], k: number): number {

    if(k <= 1) return 0;


    let prod = 1;
    let result = 0;

    let l = 0;
    let r = 0;

    while(r < nums.length){

        prod *= nums[r];

        while(prod >= k){
            prod /= nums[l];
            l++;
        }
        result = r - l + 1;
        r++;
    }


    return result;
};

export default numSubarrayProductLessThanK;

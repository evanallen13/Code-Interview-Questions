

var sortArray = function(nums) {
    
    if(nums.length == 0 || nums.length == 1) return nums;
    var isSorted = false;

    while(!isSorted){
        isSorted = true;
        for(var i = 0; i < nums.length - 1; i++){
            
            var curr = nums[i];
            var next = nums[i + 1];

            if(curr > next){
                nums[i] = next;
                nums[i + 1] = curr;
                isSorted = false;
            }
        }
    }

    return nums;
};



var nums = [5,7,1,9,3];

sortArray(nums);
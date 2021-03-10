


var twoSum = function(nums, target) {
    
    for(var i = 0; i < nums.length; i++){
        var num = nums[i];
        var need = target - num;

        if(nums.indexof(need) != -1){
            return [num, need];
        }
    }

    return[0, 0]
};

var nums = [2,7,11,15];
var target = 9;

twoSum(nums, target);
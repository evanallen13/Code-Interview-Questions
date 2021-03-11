  


var twoSum = function(nums, target) {
    
    for(var i = 0; i < nums.length; i++){
        var num = nums[i];
        var need = target - num;
        
        if(nums.indexOf(need, i) != -1){
            return [i, nums.indexOf(need, i)]
        }
    }

    return[0, 0]
};

var nums = [3,2,4];
var target = 6;

console.log(twoSum(nums, target));
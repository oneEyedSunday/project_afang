/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number[]}
 */
var twoSum = function(nums, target) {
    let index = 0;
    let found = false;
    while (!found && index < nums.length) {
        let secIndex = nums.indexOf(target - nums[index]);
        if (secIndex > -1 && secIndex != index) {
            return [index, secIndex];
        }

        if (secIndex === index) {
            secIndex = nums.lastIndexOf(target - nums[index]);
            if (secIndex > -1 && secIndex != index) {
                return [index, secIndex];
            }
        }
        index++;
    }
};

console.log(twoSum([2, 7, 11, 15], 9))
console.log(twoSum([3, 2, 3], 6))
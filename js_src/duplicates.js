/**
 * @param {number[]} nums
 * @return {boolean}
 */
var containsDuplicate = function(nums) {
    if (!nums.length) return false;
    // let i = 0;
    // let sum = nums[0];
    const map = {
        [nums[0]]: nums[0]
    };
    for (let i = 1; i < nums.length; i++)
    {
        if (map[nums[i]] != undefined) {
            return true;
        }
        map[nums[i]] = nums[i];
    }
    return false;
    // return new Set(nums).size != nums.length
};

console.log(containsDuplicate([2,14,18,22,22]));
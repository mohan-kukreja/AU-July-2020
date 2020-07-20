var arr1 = [1,2,3,4,5,6,7,8,9,10];
var arr2 = [11,12,13,14,15,16,17,18,19,20];
var arr = arr1.concat(arr2); // concat
console.log(arr);

var checkBelow21 = arr.every(function(item){ return item < 21});// evert ans = true
console.log(checkBelow21);

var filter = arr.filter(function(item){return item > 10});
console.log(filter);

var sum = 0;
arr.forEach(function(item){
    
    sum = sum + item;
    return sum;
});
console.log(sum);

var index = arr.indexOf(11);
console.log(index);

var str = arr.join();
console.log(str);

var Lindex = arr.lastIndexOf(11);
console.log(Lindex);

var mapper = arr.map(function(item){
    item ++;
    return item;
})
console.log(mapper);

var ele = arr.pop();
console.log(ele);
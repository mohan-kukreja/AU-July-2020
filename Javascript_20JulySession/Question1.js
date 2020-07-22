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

var ele = arr.push(21);
console.log(arr[arr.length-1]);

var sum = [0, 1, 2, 3].reduce(function (accumulator, currentValue) {
    return accumulator + currentValue
  }, 0)
console.log(sum);

var sum = [0, 1, 2, 3].reduceRight(function (accumulator, currentValue) {
    return accumulator + currentValue
  }, 0)
console.log(sum);

var rev = arr.reverse();
console.log(rev);

var ele = arr.shift();
console.log(ele);

var part = arr.slice(1,9);
console.log(part);

var element = arr.some(function(ele){
    return ele>4;
})
console.log(element);

var st = arr.sort();
console.log(st);

var spl = arr.splice(2,4);
console.log(arr);

var string = arr.toString();
console.log(string);

var un = arr.unshift(9);
console.log(arr);
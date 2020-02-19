// you can write to stdout for debugging purposes, e.g.
// console.log('this is a debug message');

function solution(S) {
    function match(a, b) {
        if (a === '(' && b === ')') {
            return true;
        } else if (a === '[' && b === ']') {
            return true;
        } else if (a === '{' && b === '}') {
            return true;
        }
        return false;
    }

    // write your code in JavaScript (Node.js 8.9.4
    const closingTags = [')', ']', '}'];
    const openingTags = ['(', '[', '{'];
    const stack = [];
    if (closingTags.includes(S[0])) return 0;
    for (let n = 0; n < S.length; n++) {
        const curr = S[n];
        if (openingTags.includes(curr)) stack.push(curr);
        if (closingTags.includes(curr)) {
            const prev = stack.pop();
            if (!match(prev, curr)) return 0;
        }
    }
    return stack.length === 0 ? 1 : 0;
}
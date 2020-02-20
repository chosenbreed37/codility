// you can write to stdout for debugging purposes, e.g.
// console.log('this is a debug message');

function solution(A, B) {
    // write your code in JavaScript (Node.js 8.9.4
    const stack = [];

    for (let n = 0; n < B.length; n++) {
        const curr = B[n];
        const prev = stack.pop();

        if (typeof prev !== 'undefined') {
            if (prev === 1 && curr === 0) {
                if (A[n - 1] > A[n]) {
                    stack.push(prev);
                } else {
                    stack.push(curr);
                }
            } else {
                stack.push(prev);
                stack.push(curr);
            }
        } else {
            stack.push(curr);
        }
    }

    return stack.length;
}
var isValid = function (s) {
  //* tạo một stack
  const stack = [];

  //* tạo một object để so sánh
  const match = {
    ")": "(",
    "]": "[",
    "}": "{",
  };

  for (const ch of s) {
    if (ch === "(" || ch === "[" || ch === "{") {
      stack.push(ch);
    } else if (ch === ")" || ch === "]" || ch === "}") {
      const top = stack.pop();
      if (match[ch] !== top) {
        return false;
      }
    }
    console.log("ký tự: " + ch + "		stack:", stack);
  }
  return true;
};
const b = isValid("abcg");
console.log(b);

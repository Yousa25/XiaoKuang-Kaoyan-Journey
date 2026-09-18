Cherry-pick用法：
Git cherry-pick:在有多个提交commits的时候，可以单独摘出某个commit，apply到其他分支。
在某个分支处理bug时，发现在稳定的版本中也有此bug，但是不能把整个分支去合并到已经稳定版本，又希望将这个bug去稳定的版本中去解决，通过cherry-pick：将这次提交的版本号提交到稳定的版本中。

命令：
Git cherry-pick 版本号  这个操作叫Backport


比如在dev有不同的bug，提交了不同的commits去处理不同的问题，但是prod版本和dev版本有差异，dev有些内容还是不可以上线的。可以从dev中不同的commit中选取可以上线的内容去apply到uat/prod分支中。
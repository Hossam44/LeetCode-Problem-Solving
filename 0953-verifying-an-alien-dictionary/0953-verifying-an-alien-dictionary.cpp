class Solution {
public:
    bool isAlienSorted(vector<string>& words, string order) {
        int arr[26]={0};
        bool temp;
        for(int i=0;i<order.length();i++)
        {
            arr[order[i]-'a']=i;
        }
        for(int i=0;i<words.size()-1;i++)
        {
            temp = true;
            for(int j=0;j<min(words[i].length(),words[i+1].length());j++)
            {
                if(arr[words[i][j]-'a']>arr[words[i+1][j]-'a'])
                    return false;
                else if(arr[words[i][j]-'a']<arr[words[i+1][j]-'a'])
                {
                    temp = false;
                    break;
                }
            }
            if(temp)
            {
                if(words[i].length()>words[i+1].length())
                    return false;
            }
        }
        return true;
    }

};
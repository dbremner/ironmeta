//
// IronMeta RegexpTest Parser; Generated 2015-07-25 18:08:07Z UTC
//

using System;
using System.Collections.Generic;
using System.Linq;

using IronMeta.Matcher;

#pragma warning disable 0219
#pragma warning disable 1591

namespace IronMeta.UnitTests.Matcher
{

    using _RegexpTest_Inputs = IEnumerable<char>;
    using _RegexpTest_Results = IEnumerable<int>;
    using _RegexpTest_Item = IronMeta.Matcher.MatchItem<char, int>;
    using _RegexpTest_Args = IEnumerable<IronMeta.Matcher.MatchItem<char, int>>;
    using _RegexpTest_Memo = IronMeta.Matcher.MatchState<char, int>;
    using _RegexpTest_Rule = System.Action<IronMeta.Matcher.MatchState<char, int>, int, IEnumerable<IronMeta.Matcher.MatchItem<char, int>>>;
    using _RegexpTest_Base = IronMeta.Matcher.Matcher<char, int>;

    public partial class RegexpTest : IronMeta.Matcher.Matcher<char, int>
    {
        public RegexpTest()
            : base()
        {
            _setTerminals();
        }

        public RegexpTest(bool handle_left_recursion)
            : base(handle_left_recursion)
        {
            _setTerminals();
        }

        void _setTerminals()
        {
            this.Terminals = new HashSet<string>()
            {
                "ABCD",
                "Ident",
            };
        }


        public void ABCD(_RegexpTest_Memo _memo, int _index, _RegexpTest_Args _args)
        {

            // AND 0
            int _start_i0 = _index;

            // LITERAL 'a'
            _ParseLiteralChar(_memo, ref _index, 'a');

            // AND shortcut
            if (_memo.Results.Peek() == null) { _memo.Results.Push(null); goto label0; }

            // REGEXP [\+-]?bz?cd+
            _ParseRegexp(_memo, ref _index, _re0);

        label0: // AND
            var _r0_2 = _memo.Results.Pop();
            var _r0_1 = _memo.Results.Pop();

            if (_r0_1 != null && _r0_2 != null)
            {
                _memo.Results.Push( new _RegexpTest_Item(_start_i0, _index, _memo.InputEnumerable, _r0_1.Results.Concat(_r0_2.Results).Where(_NON_NULL), true) );
            }
            else
            {
                _memo.Results.Push(null);
                _index = _start_i0;
            }

        }


        public void Ident(_RegexpTest_Memo _memo, int _index, _RegexpTest_Args _args)
        {

            // REGEXP _|_[_0-9a-zA-Z]+|[a-zA-Z][_0-9a-zA-Z]*
            _ParseRegexp(_memo, ref _index, _re1);

        }

        static readonly Verophyle.Regexp.StringRegexp _re0 = new Verophyle.Regexp.StringRegexp(@"[\+-]?bz?cd+");
        static readonly Verophyle.Regexp.StringRegexp _re1 = new Verophyle.Regexp.StringRegexp(@"_|_[_0-9a-zA-Z]+|[a-zA-Z][_0-9a-zA-Z]*");

    } // class RegexpTest

} // namespace IronMeta.UnitTests.Matcher


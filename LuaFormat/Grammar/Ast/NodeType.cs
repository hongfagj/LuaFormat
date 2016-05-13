﻿namespace Lua.LanguageService.Grammar.Ast
{
    enum NodeType
    {
        LuaUnaryOperation,
        LuaTable,
        LuaParmList,
        LuaIf,
        LuaDo,
        LuaWhile,
        LuaRepeat,
        LuaFor,
        LuaAssignment,
        LuaField,
        LuaFunctionCall,
        LuaFuncIdentifier,
        LuaIdentifierList,
        LuaFunctionDef,
        LuaChunk,
        LuaTableAccess,
        LuaFuncReturn,
        LuaLocalVariable,
        LuaExpressionList,
    }
}

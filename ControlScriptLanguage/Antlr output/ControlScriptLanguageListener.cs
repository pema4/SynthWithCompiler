//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from ControlScriptLanguage.g4 by ANTLR 4.7.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419


    using System.Linq;

using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="ControlScriptLanguageParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7.1")]
[System.CLSCompliant(false)]
public interface IControlScriptLanguageListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="ControlScriptLanguageParser.script"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterScript([NotNull] ControlScriptLanguageParser.ScriptContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ControlScriptLanguageParser.script"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitScript([NotNull] ControlScriptLanguageParser.ScriptContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ControlScriptLanguageParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatement([NotNull] ControlScriptLanguageParser.StatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ControlScriptLanguageParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatement([NotNull] ControlScriptLanguageParser.StatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ControlScriptLanguageParser.statementBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatementBlock([NotNull] ControlScriptLanguageParser.StatementBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ControlScriptLanguageParser.statementBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatementBlock([NotNull] ControlScriptLanguageParser.StatementBlockContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ControlScriptLanguageParser.prefixStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrefixStatement([NotNull] ControlScriptLanguageParser.PrefixStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ControlScriptLanguageParser.prefixStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrefixStatement([NotNull] ControlScriptLanguageParser.PrefixStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ControlScriptLanguageParser.ifStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIfStatement([NotNull] ControlScriptLanguageParser.IfStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ControlScriptLanguageParser.ifStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIfStatement([NotNull] ControlScriptLanguageParser.IfStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ControlScriptLanguageParser.whileStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWhileStatement([NotNull] ControlScriptLanguageParser.WhileStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ControlScriptLanguageParser.whileStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWhileStatement([NotNull] ControlScriptLanguageParser.WhileStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ControlScriptLanguageParser.forStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterForStatement([NotNull] ControlScriptLanguageParser.ForStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ControlScriptLanguageParser.forStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitForStatement([NotNull] ControlScriptLanguageParser.ForStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ControlScriptLanguageParser.assignableExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssignableExpression([NotNull] ControlScriptLanguageParser.AssignableExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ControlScriptLanguageParser.assignableExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssignableExpression([NotNull] ControlScriptLanguageParser.AssignableExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ControlScriptLanguageParser.primaryExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrimaryExpression([NotNull] ControlScriptLanguageParser.PrimaryExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ControlScriptLanguageParser.primaryExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrimaryExpression([NotNull] ControlScriptLanguageParser.PrimaryExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ControlScriptLanguageParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpression([NotNull] ControlScriptLanguageParser.ExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ControlScriptLanguageParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpression([NotNull] ControlScriptLanguageParser.ExpressionContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ControlScriptLanguageParser.assignmentStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssignmentStatement([NotNull] ControlScriptLanguageParser.AssignmentStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ControlScriptLanguageParser.assignmentStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssignmentStatement([NotNull] ControlScriptLanguageParser.AssignmentStatementContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ControlScriptLanguageParser.arrayDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterArrayDeclaration([NotNull] ControlScriptLanguageParser.ArrayDeclarationContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ControlScriptLanguageParser.arrayDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitArrayDeclaration([NotNull] ControlScriptLanguageParser.ArrayDeclarationContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="ControlScriptLanguageParser.constant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstant([NotNull] ControlScriptLanguageParser.ConstantContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="ControlScriptLanguageParser.constant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstant([NotNull] ControlScriptLanguageParser.ConstantContext context);
}
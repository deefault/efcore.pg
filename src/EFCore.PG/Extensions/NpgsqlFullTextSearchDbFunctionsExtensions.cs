﻿using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore.Diagnostics;
using NpgsqlTypes;

// ReSharper disable once CheckNamespace
namespace Microsoft.EntityFrameworkCore
{
    [SuppressMessage("ReSharper", "UnusedParameter.Global")]
    public static class NpgsqlFullTextSearchDbFunctionsExtensions
    {
        /// <summary>
        /// Convert <paramref name="lexemes" /> to a tsvector.
        /// </summary>
        /// <remarks>
        /// https://www.postgresql.org/docs/current/static/functions-textsearch.html
        /// </remarks>
        public static NpgsqlTsVector ArrayToTsVector(this DbFunctions _, string[] lexemes)
            => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(ArrayToTsVector)));

        /// <summary>
        /// Reduce <paramref name="document" /> to tsvector.
        /// </summary>
        /// <remarks>
        /// http://www.postgresql.org/docs/current/static/textsearch-controls.html#TEXTSEARCH-PARSING-DOCUMENTS
        /// </remarks>
        public static NpgsqlTsVector ToTsVector(this DbFunctions _, string document)
            => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(ToTsVector)));

        /// <summary>
        /// Reduce <paramref name="document" /> to tsvector using the text search configuration specified
        /// by <paramref name="config" />.
        /// </summary>
        /// <remarks>
        /// http://www.postgresql.org/docs/current/static/textsearch-controls.html#TEXTSEARCH-PARSING-DOCUMENTS
        /// </remarks>
        public static NpgsqlTsVector ToTsVector(this DbFunctions _, string config, string document)
            => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(ToTsVector)));

        /// <summary>
        /// Produce tsquery from <paramref name="query" /> ignoring punctuation.
        /// </summary>
        /// <remarks>
        /// http://www.postgresql.org/docs/current/static/textsearch-controls.html#TEXTSEARCH-PARSING-QUERIES
        /// </remarks>
        public static NpgsqlTsQuery PlainToTsQuery(this DbFunctions _, string query)
            => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(PlainToTsQuery)));

        /// <summary>
        /// Produce tsquery from <paramref name="query" /> ignoring punctuation and using the text search
        /// configuration specified by <paramref name="config" />.
        /// </summary>
        /// <remarks>
        /// http://www.postgresql.org/docs/current/static/textsearch-controls.html#TEXTSEARCH-PARSING-QUERIES
        /// </remarks>
        public static NpgsqlTsQuery PlainToTsQuery(this DbFunctions _, string config, string query)
            => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(PlainToTsQuery)));

        /// <summary>
        /// Produce tsquery that searches for a phrase from <paramref name="query" /> ignoring punctuation.
        /// </summary>
        /// <remarks>
        /// http://www.postgresql.org/docs/current/static/textsearch-controls.html#TEXTSEARCH-PARSING-QUERIES
        /// </remarks>
        public static NpgsqlTsQuery PhraseToTsQuery(this DbFunctions _, string query)
            => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(PhraseToTsQuery)));

        /// <summary>
        /// Produce tsquery that searches for a phrase from <paramref name="query" /> ignoring punctuation
        /// and using the text search configuration specified by <paramref name="config" />.
        /// </summary>
        /// <remarks>
        /// http://www.postgresql.org/docs/current/static/textsearch-controls.html#TEXTSEARCH-PARSING-QUERIES
        /// </remarks>
        public static NpgsqlTsQuery PhraseToTsQuery(this DbFunctions _, string config, string query)
            => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(PhraseToTsQuery)));

        /// <summary>
        /// Normalize words in <paramref name="query" /> and convert to tsquery. If your input
        /// contains punctuation that should not be treated as text search operators, use
        /// <see cref="PlainToTsQuery(DbFunctions, string)" /> instead.
        /// </summary>
        /// <remarks>
        /// http://www.postgresql.org/docs/current/static/textsearch-controls.html#TEXTSEARCH-PARSING-QUERIES
        /// </remarks>
        public static NpgsqlTsQuery ToTsQuery(this DbFunctions _, string query)
            => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(ToTsQuery)));

        /// <summary>
        /// Normalize words in <paramref name="query" /> and convert to tsquery using the text search
        /// configuration specified by <paramref name="config" />. If your input contains punctuation
        /// that should not be treated as text search operators, use
        /// <see cref="PlainToTsQuery(DbFunctions, string, string)" /> instead.
        /// </summary>
        /// <remarks>
        /// http://www.postgresql.org/docs/current/static/textsearch-controls.html#TEXTSEARCH-PARSING-QUERIES
        /// </remarks>
        public static NpgsqlTsQuery ToTsQuery(this DbFunctions _, string config, string query)
            => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(ToTsQuery)));

        /// <summary>
        /// Convert <paramref name="query" /> tsquery using the simplified websearch syntax.
        /// </summary>
        /// <remarks>
        /// http://www.postgresql.org/docs/current/static/textsearch-controls.html#TEXTSEARCH-PARSING-QUERIES
        /// </remarks>
        public static NpgsqlTsQuery WebSearchToTsQuery(this DbFunctions _, string query)
            => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(WebSearchToTsQuery)));

        /// <summary>
        /// Convert <paramref name="query" /> tsquery using the simplified websearch syntax and the text
        /// search configuration specified by <paramref name="config" />.
        /// </summary>
        /// <remarks>
        /// http://www.postgresql.org/docs/current/static/textsearch-controls.html#TEXTSEARCH-PARSING-QUERIES
        /// </remarks>
        public static NpgsqlTsQuery WebSearchToTsQuery(this DbFunctions _, string config, string query)
            => throw new InvalidOperationException(CoreStrings.FunctionOnClient(nameof(WebSearchToTsQuery)));
    }
}

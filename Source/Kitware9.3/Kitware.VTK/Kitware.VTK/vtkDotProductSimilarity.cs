using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDotProductSimilarity
	/// </summary>
	/// <remarks>
	///    compute dot-product similarity metrics.
	///
	///
	/// Treats matrices as collections of vectors and computes dot-product similarity
	/// metrics between vectors.
	///
	/// The results are returned as an edge-table that lists the index of each vector
	/// and their computed similarity.  The output edge-table is typically used with
	/// vtkTableToGraph to create a similarity graph.
	///
	/// This filter can be used with one or two input matrices.  If you provide a single
	/// matrix as input, every vector in the matrix is compared with every other vector. If
	/// you provide two matrices, every vector in the first matrix is compared with every
	/// vector in the second matrix.
	///
	/// Note that this filter *only* computes the dot-product between each pair of vectors;
	/// if you want to compute the cosine of the angles between vectors, you will need to
	/// normalize the inputs yourself.
	///
	/// Inputs:
	///   Input port 0: (required) A vtkDenseArray&lt;double&gt; with two dimensions (a matrix).
	///   Input port 1: (optional) A vtkDenseArray&lt;double&gt; with two dimensions (a matrix).
	///
	/// Outputs:
	///   Output port 0: A vtkTable containing "source", "target", and "similarity" columns.
	///
	/// @warning
	/// Note that the complexity of this filter is quadratic!  It also requires dense arrays
	/// as input, in the future it should be generalized to accept sparse arrays.
	///
	/// @par Thanks:
	/// </remarks>
	/// <seealso>
	/// Developed by Timothy M. Shead (tsheadndia.gov) at Sandia National Laboratories.
	/// </seealso>
	// Token: 0x02000679 RID: 1657
	public class vtkDotProductSimilarity : vtkTableAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06011D63 RID: 73059 RVA: 0x0018F5EB File Offset: 0x0018D7EB
		static vtkDotProductSimilarity()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDotProductSimilarity.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDotProductSimilarity"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06011D64 RID: 73060 RVA: 0x0018F613 File Offset: 0x0018D813
		public vtkDotProductSimilarity(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06011D65 RID: 73061
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDotProductSimilarity_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011D66 RID: 73062 RVA: 0x0018F624 File Offset: 0x0018D824
		public new static vtkDotProductSimilarity New()
		{
			vtkDotProductSimilarity result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDotProductSimilarity.vtkDotProductSimilarity_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDotProductSimilarity)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011D67 RID: 73063 RVA: 0x0018F678 File Offset: 0x0018D878
		public vtkDotProductSimilarity() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDotProductSimilarity.vtkDotProductSimilarity_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06011D68 RID: 73064 RVA: 0x0018F6BC File Offset: 0x0018D8BC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06011D69 RID: 73065
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDotProductSimilarity_GetDiagonal_01(HandleRef pThis);

		/// <summary>
		/// When computing similarities for a single input matrix, controls whether the
		/// results will include the diagonal of the similarity matrix.  Default: false.
		/// </summary>
		// Token: 0x06011D6A RID: 73066 RVA: 0x0018F6C8 File Offset: 0x0018D8C8
		public virtual int GetDiagonal()
		{
			return vtkDotProductSimilarity.vtkDotProductSimilarity_GetDiagonal_01(base.GetCppThis());
		}

		// Token: 0x06011D6B RID: 73067
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDotProductSimilarity_GetFirstSecond_02(HandleRef pThis);

		/// <summary>
		/// When computing similarities for two input matrices, controls whether the results
		/// will include comparisons from the first matrix to the second matrix.
		/// </summary>
		// Token: 0x06011D6C RID: 73068 RVA: 0x0018F6E8 File Offset: 0x0018D8E8
		public virtual int GetFirstSecond()
		{
			return vtkDotProductSimilarity.vtkDotProductSimilarity_GetFirstSecond_02(base.GetCppThis());
		}

		// Token: 0x06011D6D RID: 73069
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDotProductSimilarity_GetLowerDiagonal_03(HandleRef pThis);

		/// <summary>
		/// When computing similarities for a single input matrix, controls whether the
		/// results will include the lower diagonal of the similarity matrix.  Default: false.
		/// </summary>
		// Token: 0x06011D6E RID: 73070 RVA: 0x0018F708 File Offset: 0x0018D908
		public virtual int GetLowerDiagonal()
		{
			return vtkDotProductSimilarity.vtkDotProductSimilarity_GetLowerDiagonal_03(base.GetCppThis());
		}

		// Token: 0x06011D6F RID: 73071
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDotProductSimilarity_GetMaximumCount_04(HandleRef pThis);

		/// <summary>
		/// Specifies a maximum number of edges to include for each vector.
		/// </summary>
		// Token: 0x06011D70 RID: 73072 RVA: 0x0018F728 File Offset: 0x0018D928
		public virtual long GetMaximumCount()
		{
			return vtkDotProductSimilarity.vtkDotProductSimilarity_GetMaximumCount_04(base.GetCppThis());
		}

		// Token: 0x06011D71 RID: 73073
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDotProductSimilarity_GetMinimumCount_05(HandleRef pThis);

		/// <summary>
		/// Specifies a minimum number of edges to include for each vector.
		/// </summary>
		// Token: 0x06011D72 RID: 73074 RVA: 0x0018F748 File Offset: 0x0018D948
		public virtual long GetMinimumCount()
		{
			return vtkDotProductSimilarity.vtkDotProductSimilarity_GetMinimumCount_05(base.GetCppThis());
		}

		// Token: 0x06011D73 RID: 73075
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkDotProductSimilarity_GetMinimumThreshold_06(HandleRef pThis);

		/// <summary>
		/// Specifies a minimum threshold that a similarity must exceed to be included in
		/// the output.
		/// </summary>
		// Token: 0x06011D74 RID: 73076 RVA: 0x0018F768 File Offset: 0x0018D968
		public virtual double GetMinimumThreshold()
		{
			return vtkDotProductSimilarity.vtkDotProductSimilarity_GetMinimumThreshold_06(base.GetCppThis());
		}

		// Token: 0x06011D75 RID: 73077
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDotProductSimilarity_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011D76 RID: 73078 RVA: 0x0018F788 File Offset: 0x0018D988
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDotProductSimilarity.vtkDotProductSimilarity_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x06011D77 RID: 73079
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDotProductSimilarity_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011D78 RID: 73080 RVA: 0x0018F7A8 File Offset: 0x0018D9A8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDotProductSimilarity.vtkDotProductSimilarity_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x06011D79 RID: 73081
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDotProductSimilarity_GetSecondFirst_09(HandleRef pThis);

		/// <summary>
		/// When computing similarities for two input matrices, controls whether the results
		/// will include comparisons from the second matrix to the first matrix.
		/// </summary>
		// Token: 0x06011D7A RID: 73082 RVA: 0x0018F7C4 File Offset: 0x0018D9C4
		public virtual int GetSecondFirst()
		{
			return vtkDotProductSimilarity.vtkDotProductSimilarity_GetSecondFirst_09(base.GetCppThis());
		}

		// Token: 0x06011D7B RID: 73083
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDotProductSimilarity_GetUpperDiagonal_10(HandleRef pThis);

		/// <summary>
		/// When computing similarities for a single input matrix, controls whether the
		/// results will include the upper diagonal of the similarity matrix.  Default: true.
		/// </summary>
		// Token: 0x06011D7C RID: 73084 RVA: 0x0018F7E4 File Offset: 0x0018D9E4
		public virtual int GetUpperDiagonal()
		{
			return vtkDotProductSimilarity.vtkDotProductSimilarity_GetUpperDiagonal_10(base.GetCppThis());
		}

		// Token: 0x06011D7D RID: 73085
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDotProductSimilarity_GetVectorDimension_11(HandleRef pThis);

		/// <summary>
		/// Controls whether to compute similarities for row-vectors or column-vectors.
		/// 0 = rows, 1 = columns.
		/// </summary>
		// Token: 0x06011D7E RID: 73086 RVA: 0x0018F804 File Offset: 0x0018DA04
		public virtual long GetVectorDimension()
		{
			return vtkDotProductSimilarity.vtkDotProductSimilarity_GetVectorDimension_11(base.GetCppThis());
		}

		// Token: 0x06011D7F RID: 73087
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDotProductSimilarity_IsA_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011D80 RID: 73088 RVA: 0x0018F824 File Offset: 0x0018DA24
		public override int IsA(string type)
		{
			return vtkDotProductSimilarity.vtkDotProductSimilarity_IsA_12(base.GetCppThis(), type);
		}

		// Token: 0x06011D81 RID: 73089
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDotProductSimilarity_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011D82 RID: 73090 RVA: 0x0018F844 File Offset: 0x0018DA44
		public new static int IsTypeOf(string type)
		{
			return vtkDotProductSimilarity.vtkDotProductSimilarity_IsTypeOf_13(type);
		}

		// Token: 0x06011D83 RID: 73091
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDotProductSimilarity_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011D84 RID: 73092 RVA: 0x0018F860 File Offset: 0x0018DA60
		public new vtkDotProductSimilarity NewInstance()
		{
			vtkDotProductSimilarity result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDotProductSimilarity.vtkDotProductSimilarity_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDotProductSimilarity)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06011D85 RID: 73093
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDotProductSimilarity_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011D86 RID: 73094 RVA: 0x0018F8BC File Offset: 0x0018DABC
		public new static vtkDotProductSimilarity SafeDownCast(vtkObjectBase o)
		{
			vtkDotProductSimilarity vtkDotProductSimilarity = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDotProductSimilarity.vtkDotProductSimilarity_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDotProductSimilarity = (vtkDotProductSimilarity)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDotProductSimilarity.Register(null);
				}
			}
			return vtkDotProductSimilarity;
		}

		// Token: 0x06011D87 RID: 73095
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDotProductSimilarity_SetDiagonal_17(HandleRef pThis, int _arg);

		/// <summary>
		/// When computing similarities for a single input matrix, controls whether the
		/// results will include the diagonal of the similarity matrix.  Default: false.
		/// </summary>
		// Token: 0x06011D88 RID: 73096 RVA: 0x0018F93B File Offset: 0x0018DB3B
		public virtual void SetDiagonal(int _arg)
		{
			vtkDotProductSimilarity.vtkDotProductSimilarity_SetDiagonal_17(base.GetCppThis(), _arg);
		}

		// Token: 0x06011D89 RID: 73097
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDotProductSimilarity_SetFirstSecond_18(HandleRef pThis, int _arg);

		/// <summary>
		/// When computing similarities for two input matrices, controls whether the results
		/// will include comparisons from the first matrix to the second matrix.
		/// </summary>
		// Token: 0x06011D8A RID: 73098 RVA: 0x0018F94B File Offset: 0x0018DB4B
		public virtual void SetFirstSecond(int _arg)
		{
			vtkDotProductSimilarity.vtkDotProductSimilarity_SetFirstSecond_18(base.GetCppThis(), _arg);
		}

		// Token: 0x06011D8B RID: 73099
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDotProductSimilarity_SetLowerDiagonal_19(HandleRef pThis, int _arg);

		/// <summary>
		/// When computing similarities for a single input matrix, controls whether the
		/// results will include the lower diagonal of the similarity matrix.  Default: false.
		/// </summary>
		// Token: 0x06011D8C RID: 73100 RVA: 0x0018F95B File Offset: 0x0018DB5B
		public virtual void SetLowerDiagonal(int _arg)
		{
			vtkDotProductSimilarity.vtkDotProductSimilarity_SetLowerDiagonal_19(base.GetCppThis(), _arg);
		}

		// Token: 0x06011D8D RID: 73101
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDotProductSimilarity_SetMaximumCount_20(HandleRef pThis, long _arg);

		/// <summary>
		/// Specifies a maximum number of edges to include for each vector.
		/// </summary>
		// Token: 0x06011D8E RID: 73102 RVA: 0x0018F96B File Offset: 0x0018DB6B
		public virtual void SetMaximumCount(long _arg)
		{
			vtkDotProductSimilarity.vtkDotProductSimilarity_SetMaximumCount_20(base.GetCppThis(), _arg);
		}

		// Token: 0x06011D8F RID: 73103
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDotProductSimilarity_SetMinimumCount_21(HandleRef pThis, long _arg);

		/// <summary>
		/// Specifies a minimum number of edges to include for each vector.
		/// </summary>
		// Token: 0x06011D90 RID: 73104 RVA: 0x0018F97B File Offset: 0x0018DB7B
		public virtual void SetMinimumCount(long _arg)
		{
			vtkDotProductSimilarity.vtkDotProductSimilarity_SetMinimumCount_21(base.GetCppThis(), _arg);
		}

		// Token: 0x06011D91 RID: 73105
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDotProductSimilarity_SetMinimumThreshold_22(HandleRef pThis, double _arg);

		/// <summary>
		/// Specifies a minimum threshold that a similarity must exceed to be included in
		/// the output.
		/// </summary>
		// Token: 0x06011D92 RID: 73106 RVA: 0x0018F98B File Offset: 0x0018DB8B
		public virtual void SetMinimumThreshold(double _arg)
		{
			vtkDotProductSimilarity.vtkDotProductSimilarity_SetMinimumThreshold_22(base.GetCppThis(), _arg);
		}

		// Token: 0x06011D93 RID: 73107
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDotProductSimilarity_SetSecondFirst_23(HandleRef pThis, int _arg);

		/// <summary>
		/// When computing similarities for two input matrices, controls whether the results
		/// will include comparisons from the second matrix to the first matrix.
		/// </summary>
		// Token: 0x06011D94 RID: 73108 RVA: 0x0018F99B File Offset: 0x0018DB9B
		public virtual void SetSecondFirst(int _arg)
		{
			vtkDotProductSimilarity.vtkDotProductSimilarity_SetSecondFirst_23(base.GetCppThis(), _arg);
		}

		// Token: 0x06011D95 RID: 73109
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDotProductSimilarity_SetUpperDiagonal_24(HandleRef pThis, int _arg);

		/// <summary>
		/// When computing similarities for a single input matrix, controls whether the
		/// results will include the upper diagonal of the similarity matrix.  Default: true.
		/// </summary>
		// Token: 0x06011D96 RID: 73110 RVA: 0x0018F9AB File Offset: 0x0018DBAB
		public virtual void SetUpperDiagonal(int _arg)
		{
			vtkDotProductSimilarity.vtkDotProductSimilarity_SetUpperDiagonal_24(base.GetCppThis(), _arg);
		}

		// Token: 0x06011D97 RID: 73111
		[DllImport("Kitware.VTK.InfovisCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDotProductSimilarity_SetVectorDimension_25(HandleRef pThis, long _arg);

		/// <summary>
		/// Controls whether to compute similarities for row-vectors or column-vectors.
		/// 0 = rows, 1 = columns.
		/// </summary>
		// Token: 0x06011D98 RID: 73112 RVA: 0x0018F9BB File Offset: 0x0018DBBB
		public virtual void SetVectorDimension(long _arg)
		{
			vtkDotProductSimilarity.vtkDotProductSimilarity_SetVectorDimension_25(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001497 RID: 5271
		public new const string MRFullTypeName = "Kitware.VTK.vtkDotProductSimilarity";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001498 RID: 5272
		public new static readonly string MRClassNameKey = "class vtkDotProductSimilarity";
	}
}

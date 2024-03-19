using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkNormalizeMatrixVectors
	/// </summary>
	/// <remarks>
	///    given a sparse input matrix, produces
	/// a sparse output matrix with each vector normalized to unit length with respect
	/// to a p-norm (default p=2).
	///
	/// @par Thanks:
	/// </remarks>
	/// <seealso>
	/// Developed by Timothy M. Shead (tsheadndia.gov) at Sandia National Laboratories.
	/// </seealso>
	// Token: 0x020008C4 RID: 2244
	public class vtkNormalizeMatrixVectors : vtkArrayDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601734E RID: 95054 RVA: 0x002093A3 File Offset: 0x002075A3
		static vtkNormalizeMatrixVectors()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkNormalizeMatrixVectors.MRClassNameKey, Type.GetType("Kitware.VTK.vtkNormalizeMatrixVectors"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601734F RID: 95055 RVA: 0x002093CB File Offset: 0x002075CB
		public vtkNormalizeMatrixVectors(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06017350 RID: 95056
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNormalizeMatrixVectors_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017351 RID: 95057 RVA: 0x002093DC File Offset: 0x002075DC
		public new static vtkNormalizeMatrixVectors New()
		{
			vtkNormalizeMatrixVectors result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNormalizeMatrixVectors.vtkNormalizeMatrixVectors_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkNormalizeMatrixVectors)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017352 RID: 95058 RVA: 0x00209430 File Offset: 0x00207630
		public vtkNormalizeMatrixVectors() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkNormalizeMatrixVectors.vtkNormalizeMatrixVectors_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06017353 RID: 95059 RVA: 0x00209474 File Offset: 0x00207674
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06017354 RID: 95060
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkNormalizeMatrixVectors_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017355 RID: 95061 RVA: 0x00209480 File Offset: 0x00207680
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkNormalizeMatrixVectors.vtkNormalizeMatrixVectors_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06017356 RID: 95062
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkNormalizeMatrixVectors_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017357 RID: 95063 RVA: 0x002094A0 File Offset: 0x002076A0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkNormalizeMatrixVectors.vtkNormalizeMatrixVectors_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06017358 RID: 95064
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkNormalizeMatrixVectors_GetPValue_03(HandleRef pThis);

		/// <summary>
		/// Value of p in p-norm normalization, subject to p &gt;= 1.  Default is p=2 (Euclidean norm).
		/// </summary>
		// Token: 0x06017359 RID: 95065 RVA: 0x002094BC File Offset: 0x002076BC
		public virtual double GetPValue()
		{
			return vtkNormalizeMatrixVectors.vtkNormalizeMatrixVectors_GetPValue_03(base.GetCppThis());
		}

		// Token: 0x0601735A RID: 95066
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNormalizeMatrixVectors_GetVectorDimension_04(HandleRef pThis);

		/// <summary>
		/// Controls whether to normalize row-vectors or column-vectors.  0 = rows, 1 = columns.
		/// </summary>
		// Token: 0x0601735B RID: 95067 RVA: 0x002094DC File Offset: 0x002076DC
		public virtual int GetVectorDimension()
		{
			return vtkNormalizeMatrixVectors.vtkNormalizeMatrixVectors_GetVectorDimension_04(base.GetCppThis());
		}

		// Token: 0x0601735C RID: 95068
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNormalizeMatrixVectors_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601735D RID: 95069 RVA: 0x002094FC File Offset: 0x002076FC
		public override int IsA(string type)
		{
			return vtkNormalizeMatrixVectors.vtkNormalizeMatrixVectors_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0601735E RID: 95070
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkNormalizeMatrixVectors_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601735F RID: 95071 RVA: 0x0020951C File Offset: 0x0020771C
		public new static int IsTypeOf(string type)
		{
			return vtkNormalizeMatrixVectors.vtkNormalizeMatrixVectors_IsTypeOf_06(type);
		}

		// Token: 0x06017360 RID: 95072
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNormalizeMatrixVectors_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017361 RID: 95073 RVA: 0x00209538 File Offset: 0x00207738
		public new vtkNormalizeMatrixVectors NewInstance()
		{
			vtkNormalizeMatrixVectors result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNormalizeMatrixVectors.vtkNormalizeMatrixVectors_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkNormalizeMatrixVectors)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06017362 RID: 95074
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkNormalizeMatrixVectors_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017363 RID: 95075 RVA: 0x00209594 File Offset: 0x00207794
		public new static vtkNormalizeMatrixVectors SafeDownCast(vtkObjectBase o)
		{
			vtkNormalizeMatrixVectors vtkNormalizeMatrixVectors = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkNormalizeMatrixVectors.vtkNormalizeMatrixVectors_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkNormalizeMatrixVectors = (vtkNormalizeMatrixVectors)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkNormalizeMatrixVectors.Register(null);
				}
			}
			return vtkNormalizeMatrixVectors;
		}

		// Token: 0x06017364 RID: 95076
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNormalizeMatrixVectors_SetPValue_10(HandleRef pThis, double _arg);

		/// <summary>
		/// Value of p in p-norm normalization, subject to p &gt;= 1.  Default is p=2 (Euclidean norm).
		/// </summary>
		// Token: 0x06017365 RID: 95077 RVA: 0x00209613 File Offset: 0x00207813
		public virtual void SetPValue(double _arg)
		{
			vtkNormalizeMatrixVectors.vtkNormalizeMatrixVectors_SetPValue_10(base.GetCppThis(), _arg);
		}

		// Token: 0x06017366 RID: 95078
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkNormalizeMatrixVectors_SetVectorDimension_11(HandleRef pThis, int _arg);

		/// <summary>
		/// Controls whether to normalize row-vectors or column-vectors.  0 = rows, 1 = columns.
		/// </summary>
		// Token: 0x06017367 RID: 95079 RVA: 0x00209623 File Offset: 0x00207823
		public virtual void SetVectorDimension(int _arg)
		{
			vtkNormalizeMatrixVectors.vtkNormalizeMatrixVectors_SetVectorDimension_11(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040019FB RID: 6651
		public new const string MRFullTypeName = "Kitware.VTK.vtkNormalizeMatrixVectors";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040019FC RID: 6652
		public new static readonly string MRClassNameKey = "class vtkNormalizeMatrixVectors";
	}
}

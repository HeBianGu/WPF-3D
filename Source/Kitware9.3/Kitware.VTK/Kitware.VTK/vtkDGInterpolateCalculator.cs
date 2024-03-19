using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDGInterpolateCalculator
	/// </summary>
	/// <remarks>
	///    Interpolate a field's value and possibly derivatives at a point in a cell.
	/// </remarks>
	// Token: 0x020004DA RID: 1242
	public class vtkDGInterpolateCalculator : vtkInterpolateCalculator
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600E138 RID: 57656 RVA: 0x00138D2B File Offset: 0x00136F2B
		static vtkDGInterpolateCalculator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDGInterpolateCalculator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDGInterpolateCalculator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600E139 RID: 57657 RVA: 0x00138D53 File Offset: 0x00136F53
		public vtkDGInterpolateCalculator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600E13A RID: 57658
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDGInterpolateCalculator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E13B RID: 57659 RVA: 0x00138D64 File Offset: 0x00136F64
		public new static vtkDGInterpolateCalculator New()
		{
			vtkDGInterpolateCalculator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDGInterpolateCalculator.vtkDGInterpolateCalculator_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDGInterpolateCalculator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E13C RID: 57660 RVA: 0x00138DB8 File Offset: 0x00136FB8
		public vtkDGInterpolateCalculator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDGInterpolateCalculator.vtkDGInterpolateCalculator_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600E13D RID: 57661 RVA: 0x00138DFC File Offset: 0x00136FFC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600E13E RID: 57662
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDGInterpolateCalculator_AnalyticDerivative_01(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E13F RID: 57663 RVA: 0x00138E08 File Offset: 0x00137008
		public override bool AnalyticDerivative()
		{
			return vtkDGInterpolateCalculator.vtkDGInterpolateCalculator_AnalyticDerivative_01(base.GetCppThis()) != 0;
		}

		// Token: 0x0600E140 RID: 57664
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDGInterpolateCalculator_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E141 RID: 57665 RVA: 0x00138E30 File Offset: 0x00137030
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDGInterpolateCalculator.vtkDGInterpolateCalculator_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600E142 RID: 57666
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDGInterpolateCalculator_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E143 RID: 57667 RVA: 0x00138E50 File Offset: 0x00137050
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDGInterpolateCalculator.vtkDGInterpolateCalculator_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600E144 RID: 57668
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDGInterpolateCalculator_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E145 RID: 57669 RVA: 0x00138E6C File Offset: 0x0013706C
		public override int IsA(string type)
		{
			return vtkDGInterpolateCalculator.vtkDGInterpolateCalculator_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0600E146 RID: 57670
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDGInterpolateCalculator_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E147 RID: 57671 RVA: 0x00138E8C File Offset: 0x0013708C
		public new static int IsTypeOf(string type)
		{
			return vtkDGInterpolateCalculator.vtkDGInterpolateCalculator_IsTypeOf_05(type);
		}

		// Token: 0x0600E148 RID: 57672
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDGInterpolateCalculator_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E149 RID: 57673 RVA: 0x00138EA8 File Offset: 0x001370A8
		public new vtkDGInterpolateCalculator NewInstance()
		{
			vtkDGInterpolateCalculator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDGInterpolateCalculator.vtkDGInterpolateCalculator_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDGInterpolateCalculator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600E14A RID: 57674
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDGInterpolateCalculator_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E14B RID: 57675 RVA: 0x00138F04 File Offset: 0x00137104
		public new static vtkDGInterpolateCalculator SafeDownCast(vtkObjectBase o)
		{
			vtkDGInterpolateCalculator vtkDGInterpolateCalculator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDGInterpolateCalculator.vtkDGInterpolateCalculator_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDGInterpolateCalculator = (vtkDGInterpolateCalculator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDGInterpolateCalculator.Register(null);
				}
			}
			return vtkDGInterpolateCalculator;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400108F RID: 4239
		public new const string MRFullTypeName = "Kitware.VTK.vtkDGInterpolateCalculator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001090 RID: 4240
		public new static readonly string MRClassNameKey = "class vtkDGInterpolateCalculator";
	}
}

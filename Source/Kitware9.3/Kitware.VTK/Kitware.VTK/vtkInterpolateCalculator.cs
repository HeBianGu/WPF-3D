using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkInterpolateCalculator
	/// </summary>
	/// <remarks>
	///    Interpolate a field's value and possibly derivatives at a point in a cell.
	/// </remarks>
	// Token: 0x020004D8 RID: 1240
	public abstract class vtkInterpolateCalculator : vtkCellAttributeCalculator
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600E10C RID: 57612 RVA: 0x00138913 File Offset: 0x00136B13
		static vtkInterpolateCalculator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInterpolateCalculator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInterpolateCalculator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600E10D RID: 57613 RVA: 0x0013893B File Offset: 0x00136B3B
		public vtkInterpolateCalculator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600E10E RID: 57614 RVA: 0x00138949 File Offset: 0x00136B49
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600E10F RID: 57615
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkInterpolateCalculator_AnalyticDerivative_01(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E110 RID: 57616 RVA: 0x00138954 File Offset: 0x00136B54
		public virtual bool AnalyticDerivative()
		{
			return vtkInterpolateCalculator.vtkInterpolateCalculator_AnalyticDerivative_01(base.GetCppThis()) != 0;
		}

		// Token: 0x0600E111 RID: 57617
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInterpolateCalculator_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E112 RID: 57618 RVA: 0x0013897C File Offset: 0x00136B7C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkInterpolateCalculator.vtkInterpolateCalculator_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600E113 RID: 57619
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInterpolateCalculator_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E114 RID: 57620 RVA: 0x0013899C File Offset: 0x00136B9C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkInterpolateCalculator.vtkInterpolateCalculator_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600E115 RID: 57621
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInterpolateCalculator_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E116 RID: 57622 RVA: 0x001389B8 File Offset: 0x00136BB8
		public override int IsA(string type)
		{
			return vtkInterpolateCalculator.vtkInterpolateCalculator_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0600E117 RID: 57623
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInterpolateCalculator_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E118 RID: 57624 RVA: 0x001389D8 File Offset: 0x00136BD8
		public new static int IsTypeOf(string type)
		{
			return vtkInterpolateCalculator.vtkInterpolateCalculator_IsTypeOf_05(type);
		}

		// Token: 0x0600E119 RID: 57625
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInterpolateCalculator_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E11A RID: 57626 RVA: 0x001389F4 File Offset: 0x00136BF4
		public new vtkInterpolateCalculator NewInstance()
		{
			vtkInterpolateCalculator result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInterpolateCalculator.vtkInterpolateCalculator_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInterpolateCalculator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600E11B RID: 57627
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInterpolateCalculator_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E11C RID: 57628 RVA: 0x00138A50 File Offset: 0x00136C50
		public new static vtkInterpolateCalculator SafeDownCast(vtkObjectBase o)
		{
			vtkInterpolateCalculator vtkInterpolateCalculator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInterpolateCalculator.vtkInterpolateCalculator_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInterpolateCalculator = (vtkInterpolateCalculator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInterpolateCalculator.Register(null);
				}
			}
			return vtkInterpolateCalculator;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400108B RID: 4235
		public new const string MRFullTypeName = "Kitware.VTK.vtkInterpolateCalculator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400108C RID: 4236
		public new static readonly string MRClassNameKey = "class vtkInterpolateCalculator";
	}
}

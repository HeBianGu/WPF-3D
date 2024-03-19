using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPolyDataTangents
	/// </summary>
	/// <remarks>
	///    compute tangents for triangulated polydata
	///
	/// vtkPolyDataTangents is a filter that computes point and/or cell tangents for a triangulated
	/// polydata.
	/// This filter requires an input with both normals and tcoords on points.
	/// </remarks>
	// Token: 0x0200098D RID: 2445
	public class vtkPolyDataTangents : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060197FD RID: 104445 RVA: 0x00237E03 File Offset: 0x00236003
		static vtkPolyDataTangents()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPolyDataTangents.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPolyDataTangents"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060197FE RID: 104446 RVA: 0x00237E2B File Offset: 0x0023602B
		public vtkPolyDataTangents(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060197FF RID: 104447
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataTangents_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019800 RID: 104448 RVA: 0x00237E3C File Offset: 0x0023603C
		public new static vtkPolyDataTangents New()
		{
			vtkPolyDataTangents result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataTangents.vtkPolyDataTangents_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyDataTangents)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019801 RID: 104449 RVA: 0x00237E90 File Offset: 0x00236090
		public vtkPolyDataTangents() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPolyDataTangents.vtkPolyDataTangents_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06019802 RID: 104450 RVA: 0x00237ED4 File Offset: 0x002360D4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06019803 RID: 104451
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataTangents_ComputeCellTangentsOff_01(HandleRef pThis);

		/// <summary>
		/// Turn on/off the computation of cell tangents.
		/// Default is false.
		/// </summary>
		// Token: 0x06019804 RID: 104452 RVA: 0x00237EDF File Offset: 0x002360DF
		public virtual void ComputeCellTangentsOff()
		{
			vtkPolyDataTangents.vtkPolyDataTangents_ComputeCellTangentsOff_01(base.GetCppThis());
		}

		// Token: 0x06019805 RID: 104453
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataTangents_ComputeCellTangentsOn_02(HandleRef pThis);

		/// <summary>
		/// Turn on/off the computation of cell tangents.
		/// Default is false.
		/// </summary>
		// Token: 0x06019806 RID: 104454 RVA: 0x00237EEE File Offset: 0x002360EE
		public virtual void ComputeCellTangentsOn()
		{
			vtkPolyDataTangents.vtkPolyDataTangents_ComputeCellTangentsOn_02(base.GetCppThis());
		}

		// Token: 0x06019807 RID: 104455
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataTangents_ComputePointTangentsOff_03(HandleRef pThis);

		/// <summary>
		/// Turn on/off the computation of point tangents.
		/// Default is true.
		/// </summary>
		// Token: 0x06019808 RID: 104456 RVA: 0x00237EFD File Offset: 0x002360FD
		public virtual void ComputePointTangentsOff()
		{
			vtkPolyDataTangents.vtkPolyDataTangents_ComputePointTangentsOff_03(base.GetCppThis());
		}

		// Token: 0x06019809 RID: 104457
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataTangents_ComputePointTangentsOn_04(HandleRef pThis);

		/// <summary>
		/// Turn on/off the computation of point tangents.
		/// Default is true.
		/// </summary>
		// Token: 0x0601980A RID: 104458 RVA: 0x00237F0C File Offset: 0x0023610C
		public virtual void ComputePointTangentsOn()
		{
			vtkPolyDataTangents.vtkPolyDataTangents_ComputePointTangentsOn_04(base.GetCppThis());
		}

		// Token: 0x0601980B RID: 104459
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPolyDataTangents_GetComputeCellTangents_05(HandleRef pThis);

		/// <summary>
		/// Turn on/off the computation of cell tangents.
		/// Default is false.
		/// </summary>
		// Token: 0x0601980C RID: 104460 RVA: 0x00237F1C File Offset: 0x0023611C
		public virtual bool GetComputeCellTangents()
		{
			return vtkPolyDataTangents.vtkPolyDataTangents_GetComputeCellTangents_05(base.GetCppThis()) != 0;
		}

		// Token: 0x0601980D RID: 104461
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkPolyDataTangents_GetComputePointTangents_06(HandleRef pThis);

		/// <summary>
		/// Turn on/off the computation of point tangents.
		/// Default is true.
		/// </summary>
		// Token: 0x0601980E RID: 104462 RVA: 0x00237F44 File Offset: 0x00236144
		public virtual bool GetComputePointTangents()
		{
			return vtkPolyDataTangents.vtkPolyDataTangents_GetComputePointTangents_06(base.GetCppThis()) != 0;
		}

		// Token: 0x0601980F RID: 104463
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyDataTangents_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019810 RID: 104464 RVA: 0x00237F6C File Offset: 0x0023616C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPolyDataTangents.vtkPolyDataTangents_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x06019811 RID: 104465
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPolyDataTangents_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019812 RID: 104466 RVA: 0x00237F8C File Offset: 0x0023618C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPolyDataTangents.vtkPolyDataTangents_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x06019813 RID: 104467
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataTangents_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019814 RID: 104468 RVA: 0x00237FA8 File Offset: 0x002361A8
		public override int IsA(string type)
		{
			return vtkPolyDataTangents.vtkPolyDataTangents_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x06019815 RID: 104469
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPolyDataTangents_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019816 RID: 104470 RVA: 0x00237FC8 File Offset: 0x002361C8
		public new static int IsTypeOf(string type)
		{
			return vtkPolyDataTangents.vtkPolyDataTangents_IsTypeOf_10(type);
		}

		// Token: 0x06019817 RID: 104471
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataTangents_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019818 RID: 104472 RVA: 0x00237FE4 File Offset: 0x002361E4
		public new vtkPolyDataTangents NewInstance()
		{
			vtkPolyDataTangents result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataTangents.vtkPolyDataTangents_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPolyDataTangents)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06019819 RID: 104473
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPolyDataTangents_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601981A RID: 104474 RVA: 0x00238040 File Offset: 0x00236240
		public new static vtkPolyDataTangents SafeDownCast(vtkObjectBase o)
		{
			vtkPolyDataTangents vtkPolyDataTangents = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPolyDataTangents.vtkPolyDataTangents_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPolyDataTangents = (vtkPolyDataTangents)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPolyDataTangents.Register(null);
				}
			}
			return vtkPolyDataTangents;
		}

		// Token: 0x0601981B RID: 104475
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataTangents_SetComputeCellTangents_14(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on/off the computation of cell tangents.
		/// Default is false.
		/// </summary>
		// Token: 0x0601981C RID: 104476 RVA: 0x002380BF File Offset: 0x002362BF
		public virtual void SetComputeCellTangents(bool _arg)
		{
			vtkPolyDataTangents.vtkPolyDataTangents_SetComputeCellTangents_14(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0601981D RID: 104477
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPolyDataTangents_SetComputePointTangents_15(HandleRef pThis, byte _arg);

		/// <summary>
		/// Turn on/off the computation of point tangents.
		/// Default is true.
		/// </summary>
		// Token: 0x0601981E RID: 104478 RVA: 0x002380D7 File Offset: 0x002362D7
		public virtual void SetComputePointTangents(bool _arg)
		{
			vtkPolyDataTangents.vtkPolyDataTangents_SetComputePointTangents_15(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001BDB RID: 7131
		public new const string MRFullTypeName = "Kitware.VTK.vtkPolyDataTangents";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001BDC RID: 7132
		public new static readonly string MRClassNameKey = "class vtkPolyDataTangents";
	}
}

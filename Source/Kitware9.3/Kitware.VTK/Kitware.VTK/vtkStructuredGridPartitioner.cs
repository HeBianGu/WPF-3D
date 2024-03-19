using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkStructuredGridPartitioner
	///
	///
	///  A concrete implementation of vtkMultiBlockDataSetAlgorithm that provides
	///  functionality for partitioning a VTK structured grid dataset. The partition-
	///  ing method used is Recursive Coordinate Bisection (RCB) where each time the
	///  longest dimension is split.
	///
	/// </summary>
	/// <seealso>
	///
	///  vtkUniformGridPartitioner vtkRectilinearGridPartitioner
	/// </seealso>
	// Token: 0x02000916 RID: 2326
	public class vtkStructuredGridPartitioner : vtkMultiBlockDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601818E RID: 98702 RVA: 0x0021BA3F File Offset: 0x00219C3F
		static vtkStructuredGridPartitioner()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStructuredGridPartitioner.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStructuredGridPartitioner"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601818F RID: 98703 RVA: 0x0021BA67 File Offset: 0x00219C67
		public vtkStructuredGridPartitioner(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06018190 RID: 98704
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredGridPartitioner_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018191 RID: 98705 RVA: 0x0021BA78 File Offset: 0x00219C78
		public new static vtkStructuredGridPartitioner New()
		{
			vtkStructuredGridPartitioner result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredGridPartitioner.vtkStructuredGridPartitioner_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStructuredGridPartitioner)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018192 RID: 98706 RVA: 0x0021BACC File Offset: 0x00219CCC
		public vtkStructuredGridPartitioner() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkStructuredGridPartitioner.vtkStructuredGridPartitioner_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06018193 RID: 98707 RVA: 0x0021BB10 File Offset: 0x00219D10
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06018194 RID: 98708
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredGridPartitioner_DuplicateNodesOff_01(HandleRef pThis);

		/// <summary>
		/// Set/Get &amp; boolean macro for the DuplicateNodes property.
		/// </summary>
		// Token: 0x06018195 RID: 98709 RVA: 0x0021BB1B File Offset: 0x00219D1B
		public virtual void DuplicateNodesOff()
		{
			vtkStructuredGridPartitioner.vtkStructuredGridPartitioner_DuplicateNodesOff_01(base.GetCppThis());
		}

		// Token: 0x06018196 RID: 98710
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredGridPartitioner_DuplicateNodesOn_02(HandleRef pThis);

		/// <summary>
		/// Set/Get &amp; boolean macro for the DuplicateNodes property.
		/// </summary>
		// Token: 0x06018197 RID: 98711 RVA: 0x0021BB2A File Offset: 0x00219D2A
		public virtual void DuplicateNodesOn()
		{
			vtkStructuredGridPartitioner.vtkStructuredGridPartitioner_DuplicateNodesOn_02(base.GetCppThis());
		}

		// Token: 0x06018198 RID: 98712
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStructuredGridPartitioner_GetDuplicateNodes_03(HandleRef pThis);

		/// <summary>
		/// Set/Get &amp; boolean macro for the DuplicateNodes property.
		/// </summary>
		// Token: 0x06018199 RID: 98713 RVA: 0x0021BB3C File Offset: 0x00219D3C
		public virtual int GetDuplicateNodes()
		{
			return vtkStructuredGridPartitioner.vtkStructuredGridPartitioner_GetDuplicateNodes_03(base.GetCppThis());
		}

		// Token: 0x0601819A RID: 98714
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStructuredGridPartitioner_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601819B RID: 98715 RVA: 0x0021BB5C File Offset: 0x00219D5C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkStructuredGridPartitioner.vtkStructuredGridPartitioner_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0601819C RID: 98716
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStructuredGridPartitioner_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601819D RID: 98717 RVA: 0x0021BB7C File Offset: 0x00219D7C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkStructuredGridPartitioner.vtkStructuredGridPartitioner_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0601819E RID: 98718
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStructuredGridPartitioner_GetNumberOfGhostLayers_06(HandleRef pThis);

		/// <summary>
		/// Set/Get macro for the number of ghost layers.
		/// </summary>
		// Token: 0x0601819F RID: 98719 RVA: 0x0021BB98 File Offset: 0x00219D98
		public virtual int GetNumberOfGhostLayers()
		{
			return vtkStructuredGridPartitioner.vtkStructuredGridPartitioner_GetNumberOfGhostLayers_06(base.GetCppThis());
		}

		// Token: 0x060181A0 RID: 98720
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStructuredGridPartitioner_GetNumberOfPartitions_07(HandleRef pThis);

		/// <summary>
		/// Set/Get macro for the number of subdivisions.
		/// </summary>
		// Token: 0x060181A1 RID: 98721 RVA: 0x0021BBB8 File Offset: 0x00219DB8
		public virtual int GetNumberOfPartitions()
		{
			return vtkStructuredGridPartitioner.vtkStructuredGridPartitioner_GetNumberOfPartitions_07(base.GetCppThis());
		}

		// Token: 0x060181A2 RID: 98722
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStructuredGridPartitioner_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060181A3 RID: 98723 RVA: 0x0021BBD8 File Offset: 0x00219DD8
		public override int IsA(string type)
		{
			return vtkStructuredGridPartitioner.vtkStructuredGridPartitioner_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x060181A4 RID: 98724
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStructuredGridPartitioner_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060181A5 RID: 98725 RVA: 0x0021BBF8 File Offset: 0x00219DF8
		public new static int IsTypeOf(string type)
		{
			return vtkStructuredGridPartitioner.vtkStructuredGridPartitioner_IsTypeOf_09(type);
		}

		// Token: 0x060181A6 RID: 98726
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredGridPartitioner_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060181A7 RID: 98727 RVA: 0x0021BC14 File Offset: 0x00219E14
		public new vtkStructuredGridPartitioner NewInstance()
		{
			vtkStructuredGridPartitioner result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredGridPartitioner.vtkStructuredGridPartitioner_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStructuredGridPartitioner)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060181A8 RID: 98728
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredGridPartitioner_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060181A9 RID: 98729 RVA: 0x0021BC70 File Offset: 0x00219E70
		public new static vtkStructuredGridPartitioner SafeDownCast(vtkObjectBase o)
		{
			vtkStructuredGridPartitioner vtkStructuredGridPartitioner = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredGridPartitioner.vtkStructuredGridPartitioner_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredGridPartitioner = (vtkStructuredGridPartitioner)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredGridPartitioner.Register(null);
				}
			}
			return vtkStructuredGridPartitioner;
		}

		// Token: 0x060181AA RID: 98730
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredGridPartitioner_SetDuplicateNodes_13(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get &amp; boolean macro for the DuplicateNodes property.
		/// </summary>
		// Token: 0x060181AB RID: 98731 RVA: 0x0021BCEF File Offset: 0x00219EEF
		public virtual void SetDuplicateNodes(int _arg)
		{
			vtkStructuredGridPartitioner.vtkStructuredGridPartitioner_SetDuplicateNodes_13(base.GetCppThis(), _arg);
		}

		// Token: 0x060181AC RID: 98732
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredGridPartitioner_SetNumberOfGhostLayers_14(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get macro for the number of ghost layers.
		/// </summary>
		// Token: 0x060181AD RID: 98733 RVA: 0x0021BCFF File Offset: 0x00219EFF
		public virtual void SetNumberOfGhostLayers(int _arg)
		{
			vtkStructuredGridPartitioner.vtkStructuredGridPartitioner_SetNumberOfGhostLayers_14(base.GetCppThis(), _arg);
		}

		// Token: 0x060181AE RID: 98734
		[DllImport("Kitware.VTK.FiltersGeometry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredGridPartitioner_SetNumberOfPartitions_15(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get macro for the number of subdivisions.
		/// </summary>
		// Token: 0x060181AF RID: 98735 RVA: 0x0021BD0F File Offset: 0x00219F0F
		public virtual void SetNumberOfPartitions(int _arg)
		{
			vtkStructuredGridPartitioner.vtkStructuredGridPartitioner_SetNumberOfPartitions_15(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001AD6 RID: 6870
		public new const string MRFullTypeName = "Kitware.VTK.vtkStructuredGridPartitioner";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001AD7 RID: 6871
		public new static readonly string MRClassNameKey = "class vtkStructuredGridPartitioner";
	}
}

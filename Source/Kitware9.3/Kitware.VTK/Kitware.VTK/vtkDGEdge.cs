using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDGEdge
	/// </summary>
	/// <remarks>
	///    Metadata for a discontinuous Galerkin triangle.
	///
	/// Currently, only a linear shape is supported but this
	/// may change to arbitrary order.
	/// </remarks>
	// Token: 0x020004DF RID: 1247
	public class vtkDGEdge : vtkDGCell
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600E1C8 RID: 57800 RVA: 0x00139C43 File Offset: 0x00137E43
		static vtkDGEdge()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDGEdge.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDGEdge"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600E1C9 RID: 57801 RVA: 0x00139C6B File Offset: 0x00137E6B
		public vtkDGEdge(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600E1CA RID: 57802
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDGEdge_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E1CB RID: 57803 RVA: 0x00139C7C File Offset: 0x00137E7C
		public new static vtkDGEdge New()
		{
			vtkDGEdge result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDGEdge.vtkDGEdge_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDGEdge)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E1CC RID: 57804 RVA: 0x00139CD0 File Offset: 0x00137ED0
		public vtkDGEdge() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDGEdge.vtkDGEdge_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600E1CD RID: 57805 RVA: 0x00139D14 File Offset: 0x00137F14
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600E1CE RID: 57806
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDGEdge_GetDimension_01(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E1CF RID: 57807 RVA: 0x00139D20 File Offset: 0x00137F20
		public override int GetDimension()
		{
			return vtkDGEdge.vtkDGEdge_GetDimension_01(base.GetCppThis());
		}

		// Token: 0x0600E1D0 RID: 57808
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDGEdge_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E1D1 RID: 57809 RVA: 0x00139D40 File Offset: 0x00137F40
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDGEdge.vtkDGEdge_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600E1D2 RID: 57810
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDGEdge_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E1D3 RID: 57811 RVA: 0x00139D60 File Offset: 0x00137F60
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDGEdge.vtkDGEdge_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600E1D4 RID: 57812
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDGEdge_GetNumberOfSideTypes_04(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E1D5 RID: 57813 RVA: 0x00139D7C File Offset: 0x00137F7C
		public override int GetNumberOfSideTypes()
		{
			return vtkDGEdge.vtkDGEdge_GetNumberOfSideTypes_04(base.GetCppThis());
		}

		// Token: 0x0600E1D6 RID: 57814
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDGEdge_GetNumberOfSidesOfDimension_05(HandleRef pThis, int dimension);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E1D7 RID: 57815 RVA: 0x00139D9C File Offset: 0x00137F9C
		public override int GetNumberOfSidesOfDimension(int dimension)
		{
			return vtkDGEdge.vtkDGEdge_GetNumberOfSidesOfDimension_05(base.GetCppThis(), dimension);
		}

		// Token: 0x0600E1D8 RID: 57816
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDGEdge_GetReferencePoints_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E1D9 RID: 57817 RVA: 0x00139DBC File Offset: 0x00137FBC
		public override vtkTypeFloat32Array GetReferencePoints()
		{
			vtkTypeFloat32Array vtkTypeFloat32Array = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDGEdge.vtkDGEdge_GetReferencePoints_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTypeFloat32Array = (vtkTypeFloat32Array)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTypeFloat32Array.Register(null);
				}
			}
			return vtkTypeFloat32Array;
		}

		// Token: 0x0600E1DA RID: 57818
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkDGCell.Shape vtkDGEdge_GetShape_07(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E1DB RID: 57819 RVA: 0x00139E2C File Offset: 0x0013802C
		public override vtkDGCell.Shape GetShape()
		{
			return vtkDGEdge.vtkDGEdge_GetShape_07(base.GetCppThis());
		}

		// Token: 0x0600E1DC RID: 57820
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDGEdge_GetSideConnectivity_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E1DD RID: 57821 RVA: 0x00139E4C File Offset: 0x0013804C
		public override vtkTypeInt32Array GetSideConnectivity()
		{
			vtkTypeInt32Array vtkTypeInt32Array = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDGEdge.vtkDGEdge_GetSideConnectivity_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTypeInt32Array = (vtkTypeInt32Array)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTypeInt32Array.Register(null);
				}
			}
			return vtkTypeInt32Array;
		}

		// Token: 0x0600E1DE RID: 57822
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDGEdge_GetSideOffsetsAndShapes_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E1DF RID: 57823 RVA: 0x00139EBC File Offset: 0x001380BC
		public override vtkTypeInt32Array GetSideOffsetsAndShapes()
		{
			vtkTypeInt32Array vtkTypeInt32Array = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDGEdge.vtkDGEdge_GetSideOffsetsAndShapes_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTypeInt32Array = (vtkTypeInt32Array)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTypeInt32Array.Register(null);
				}
			}
			return vtkTypeInt32Array;
		}

		// Token: 0x0600E1E0 RID: 57824
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkDGCell.Shape vtkDGEdge_GetSideShape_10(HandleRef pThis, int side);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E1E1 RID: 57825 RVA: 0x00139F2C File Offset: 0x0013812C
		public override vtkDGCell.Shape GetSideShape(int side)
		{
			return vtkDGEdge.vtkDGEdge_GetSideShape_10(base.GetCppThis(), side);
		}

		// Token: 0x0600E1E2 RID: 57826
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDGEdge_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E1E3 RID: 57827 RVA: 0x00139F4C File Offset: 0x0013814C
		public override int IsA(string type)
		{
			return vtkDGEdge.vtkDGEdge_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x0600E1E4 RID: 57828
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDGEdge_IsInside_12(HandleRef pThis, HandleRef rst, double tolerance);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E1E5 RID: 57829 RVA: 0x00139F6C File Offset: 0x0013816C
		public override bool IsInside(vtkVector3d rst, double tolerance)
		{
			return vtkDGEdge.vtkDGEdge_IsInside_12(base.GetCppThis(), (rst == null) ? default(HandleRef) : rst.GetCppThis(), tolerance) != 0;
		}

		// Token: 0x0600E1E6 RID: 57830
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDGEdge_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E1E7 RID: 57831 RVA: 0x00139FA8 File Offset: 0x001381A8
		public new static int IsTypeOf(string type)
		{
			return vtkDGEdge.vtkDGEdge_IsTypeOf_13(type);
		}

		// Token: 0x0600E1E8 RID: 57832
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDGEdge_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E1E9 RID: 57833 RVA: 0x00139FC4 File Offset: 0x001381C4
		public new vtkDGEdge NewInstance()
		{
			vtkDGEdge result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDGEdge.vtkDGEdge_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDGEdge)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600E1EA RID: 57834
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDGEdge_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E1EB RID: 57835 RVA: 0x0013A020 File Offset: 0x00138220
		public new static vtkDGEdge SafeDownCast(vtkObjectBase o)
		{
			vtkDGEdge vtkDGEdge = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDGEdge.vtkDGEdge_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDGEdge = (vtkDGEdge)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDGEdge.Register(null);
				}
			}
			return vtkDGEdge;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040010A1 RID: 4257
		public new const string MRFullTypeName = "Kitware.VTK.vtkDGEdge";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040010A2 RID: 4258
		public new static readonly string MRClassNameKey = "class vtkDGEdge";
	}
}

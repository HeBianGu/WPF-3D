using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDGTri
	/// </summary>
	/// <remarks>
	///    Metadata for a discontinuous Galerkin triangle.
	///
	/// Currently, only a linear shape is supported but this
	/// may change to arbitrary order.
	/// </remarks>
	// Token: 0x020004E5 RID: 1253
	public class vtkDGTri : vtkDeRhamCell
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600E28B RID: 57995 RVA: 0x0013B3A3 File Offset: 0x001395A3
		static vtkDGTri()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDGTri.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDGTri"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600E28C RID: 57996 RVA: 0x0013B3CB File Offset: 0x001395CB
		public vtkDGTri(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600E28D RID: 57997
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDGTri_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E28E RID: 57998 RVA: 0x0013B3DC File Offset: 0x001395DC
		public new static vtkDGTri New()
		{
			vtkDGTri result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDGTri.vtkDGTri_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDGTri)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E28F RID: 57999 RVA: 0x0013B430 File Offset: 0x00139630
		public vtkDGTri() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDGTri.vtkDGTri_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600E290 RID: 58000 RVA: 0x0013B474 File Offset: 0x00139674
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600E291 RID: 58001
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDGTri_GetDimension_01(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E292 RID: 58002 RVA: 0x0013B480 File Offset: 0x00139680
		public override int GetDimension()
		{
			return vtkDGTri.vtkDGTri_GetDimension_01(base.GetCppThis());
		}

		// Token: 0x0600E293 RID: 58003
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDGTri_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E294 RID: 58004 RVA: 0x0013B4A0 File Offset: 0x001396A0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDGTri.vtkDGTri_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600E295 RID: 58005
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDGTri_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E296 RID: 58006 RVA: 0x0013B4C0 File Offset: 0x001396C0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDGTri.vtkDGTri_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600E297 RID: 58007
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDGTri_GetNumberOfSideTypes_04(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E298 RID: 58008 RVA: 0x0013B4DC File Offset: 0x001396DC
		public override int GetNumberOfSideTypes()
		{
			return vtkDGTri.vtkDGTri_GetNumberOfSideTypes_04(base.GetCppThis());
		}

		// Token: 0x0600E299 RID: 58009
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDGTri_GetNumberOfSidesOfDimension_05(HandleRef pThis, int dimension);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E29A RID: 58010 RVA: 0x0013B4FC File Offset: 0x001396FC
		public override int GetNumberOfSidesOfDimension(int dimension)
		{
			return vtkDGTri.vtkDGTri_GetNumberOfSidesOfDimension_05(base.GetCppThis(), dimension);
		}

		// Token: 0x0600E29B RID: 58011
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDGTri_GetReferencePoints_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E29C RID: 58012 RVA: 0x0013B51C File Offset: 0x0013971C
		public override vtkTypeFloat32Array GetReferencePoints()
		{
			vtkTypeFloat32Array vtkTypeFloat32Array = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDGTri.vtkDGTri_GetReferencePoints_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600E29D RID: 58013
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkDGCell.Shape vtkDGTri_GetShape_07(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E29E RID: 58014 RVA: 0x0013B58C File Offset: 0x0013978C
		public override vtkDGCell.Shape GetShape()
		{
			return vtkDGTri.vtkDGTri_GetShape_07(base.GetCppThis());
		}

		// Token: 0x0600E29F RID: 58015
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDGTri_GetSideConnectivity_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E2A0 RID: 58016 RVA: 0x0013B5AC File Offset: 0x001397AC
		public override vtkTypeInt32Array GetSideConnectivity()
		{
			vtkTypeInt32Array vtkTypeInt32Array = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDGTri.vtkDGTri_GetSideConnectivity_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600E2A1 RID: 58017
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDGTri_GetSideOffsetsAndShapes_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E2A2 RID: 58018 RVA: 0x0013B61C File Offset: 0x0013981C
		public override vtkTypeInt32Array GetSideOffsetsAndShapes()
		{
			vtkTypeInt32Array vtkTypeInt32Array = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDGTri.vtkDGTri_GetSideOffsetsAndShapes_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600E2A3 RID: 58019
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkDGCell.Shape vtkDGTri_GetSideShape_10(HandleRef pThis, int side);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E2A4 RID: 58020 RVA: 0x0013B68C File Offset: 0x0013988C
		public override vtkDGCell.Shape GetSideShape(int side)
		{
			return vtkDGTri.vtkDGTri_GetSideShape_10(base.GetCppThis(), side);
		}

		// Token: 0x0600E2A5 RID: 58021
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDGTri_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E2A6 RID: 58022 RVA: 0x0013B6AC File Offset: 0x001398AC
		public override int IsA(string type)
		{
			return vtkDGTri.vtkDGTri_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x0600E2A7 RID: 58023
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDGTri_IsInside_12(HandleRef pThis, HandleRef rst, double tolerance);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E2A8 RID: 58024 RVA: 0x0013B6CC File Offset: 0x001398CC
		public override bool IsInside(vtkVector3d rst, double tolerance)
		{
			return vtkDGTri.vtkDGTri_IsInside_12(base.GetCppThis(), (rst == null) ? default(HandleRef) : rst.GetCppThis(), tolerance) != 0;
		}

		// Token: 0x0600E2A9 RID: 58025
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDGTri_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E2AA RID: 58026 RVA: 0x0013B708 File Offset: 0x00139908
		public new static int IsTypeOf(string type)
		{
			return vtkDGTri.vtkDGTri_IsTypeOf_13(type);
		}

		// Token: 0x0600E2AB RID: 58027
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDGTri_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E2AC RID: 58028 RVA: 0x0013B724 File Offset: 0x00139924
		public new vtkDGTri NewInstance()
		{
			vtkDGTri result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDGTri.vtkDGTri_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDGTri)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600E2AD RID: 58029
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDGTri_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E2AE RID: 58030 RVA: 0x0013B780 File Offset: 0x00139980
		public new static vtkDGTri SafeDownCast(vtkObjectBase o)
		{
			vtkDGTri vtkDGTri = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDGTri.vtkDGTri_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDGTri = (vtkDGTri)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDGTri.Register(null);
				}
			}
			return vtkDGTri;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040010AD RID: 4269
		public new const string MRFullTypeName = "Kitware.VTK.vtkDGTri";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040010AE RID: 4270
		public new static readonly string MRClassNameKey = "class vtkDGTri";
	}
}

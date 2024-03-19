using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDGVert
	/// </summary>
	/// <remarks>
	///    Metadata for a discontinuous Galerkin vertex.
	///
	/// </remarks>
	// Token: 0x020004E6 RID: 1254
	public class vtkDGVert : vtkDGCell
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600E2AF RID: 58031 RVA: 0x0013B7FF File Offset: 0x001399FF
		static vtkDGVert()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDGVert.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDGVert"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600E2B0 RID: 58032 RVA: 0x0013B827 File Offset: 0x00139A27
		public vtkDGVert(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600E2B1 RID: 58033
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDGVert_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E2B2 RID: 58034 RVA: 0x0013B838 File Offset: 0x00139A38
		public new static vtkDGVert New()
		{
			vtkDGVert result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDGVert.vtkDGVert_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDGVert)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E2B3 RID: 58035 RVA: 0x0013B88C File Offset: 0x00139A8C
		public vtkDGVert() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDGVert.vtkDGVert_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600E2B4 RID: 58036 RVA: 0x0013B8D0 File Offset: 0x00139AD0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600E2B5 RID: 58037
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDGVert_GetDimension_01(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E2B6 RID: 58038 RVA: 0x0013B8DC File Offset: 0x00139ADC
		public override int GetDimension()
		{
			return vtkDGVert.vtkDGVert_GetDimension_01(base.GetCppThis());
		}

		// Token: 0x0600E2B7 RID: 58039
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDGVert_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E2B8 RID: 58040 RVA: 0x0013B8FC File Offset: 0x00139AFC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDGVert.vtkDGVert_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600E2B9 RID: 58041
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDGVert_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E2BA RID: 58042 RVA: 0x0013B91C File Offset: 0x00139B1C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDGVert.vtkDGVert_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600E2BB RID: 58043
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDGVert_GetNumberOfSideTypes_04(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E2BC RID: 58044 RVA: 0x0013B938 File Offset: 0x00139B38
		public override int GetNumberOfSideTypes()
		{
			return vtkDGVert.vtkDGVert_GetNumberOfSideTypes_04(base.GetCppThis());
		}

		// Token: 0x0600E2BD RID: 58045
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDGVert_GetNumberOfSidesOfDimension_05(HandleRef pThis, int dimension);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E2BE RID: 58046 RVA: 0x0013B958 File Offset: 0x00139B58
		public override int GetNumberOfSidesOfDimension(int dimension)
		{
			return vtkDGVert.vtkDGVert_GetNumberOfSidesOfDimension_05(base.GetCppThis(), dimension);
		}

		// Token: 0x0600E2BF RID: 58047
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDGVert_GetReferencePoints_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E2C0 RID: 58048 RVA: 0x0013B978 File Offset: 0x00139B78
		public override vtkTypeFloat32Array GetReferencePoints()
		{
			vtkTypeFloat32Array vtkTypeFloat32Array = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDGVert.vtkDGVert_GetReferencePoints_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600E2C1 RID: 58049
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkDGCell.Shape vtkDGVert_GetShape_07(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E2C2 RID: 58050 RVA: 0x0013B9E8 File Offset: 0x00139BE8
		public override vtkDGCell.Shape GetShape()
		{
			return vtkDGVert.vtkDGVert_GetShape_07(base.GetCppThis());
		}

		// Token: 0x0600E2C3 RID: 58051
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDGVert_GetSideConnectivity_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E2C4 RID: 58052 RVA: 0x0013BA08 File Offset: 0x00139C08
		public override vtkTypeInt32Array GetSideConnectivity()
		{
			vtkTypeInt32Array vtkTypeInt32Array = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDGVert.vtkDGVert_GetSideConnectivity_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600E2C5 RID: 58053
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDGVert_GetSideOffsetsAndShapes_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E2C6 RID: 58054 RVA: 0x0013BA78 File Offset: 0x00139C78
		public override vtkTypeInt32Array GetSideOffsetsAndShapes()
		{
			vtkTypeInt32Array vtkTypeInt32Array = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDGVert.vtkDGVert_GetSideOffsetsAndShapes_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600E2C7 RID: 58055
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkDGCell.Shape vtkDGVert_GetSideShape_10(HandleRef pThis, int side);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E2C8 RID: 58056 RVA: 0x0013BAE8 File Offset: 0x00139CE8
		public override vtkDGCell.Shape GetSideShape(int side)
		{
			return vtkDGVert.vtkDGVert_GetSideShape_10(base.GetCppThis(), side);
		}

		// Token: 0x0600E2C9 RID: 58057
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDGVert_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E2CA RID: 58058 RVA: 0x0013BB08 File Offset: 0x00139D08
		public override int IsA(string type)
		{
			return vtkDGVert.vtkDGVert_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x0600E2CB RID: 58059
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDGVert_IsInside_12(HandleRef pThis, HandleRef rst, double tolerance);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E2CC RID: 58060 RVA: 0x0013BB28 File Offset: 0x00139D28
		public override bool IsInside(vtkVector3d rst, double tolerance)
		{
			return vtkDGVert.vtkDGVert_IsInside_12(base.GetCppThis(), (rst == null) ? default(HandleRef) : rst.GetCppThis(), tolerance) != 0;
		}

		// Token: 0x0600E2CD RID: 58061
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDGVert_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E2CE RID: 58062 RVA: 0x0013BB64 File Offset: 0x00139D64
		public new static int IsTypeOf(string type)
		{
			return vtkDGVert.vtkDGVert_IsTypeOf_13(type);
		}

		// Token: 0x0600E2CF RID: 58063
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDGVert_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E2D0 RID: 58064 RVA: 0x0013BB80 File Offset: 0x00139D80
		public new vtkDGVert NewInstance()
		{
			vtkDGVert result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDGVert.vtkDGVert_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDGVert)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600E2D1 RID: 58065
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDGVert_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E2D2 RID: 58066 RVA: 0x0013BBDC File Offset: 0x00139DDC
		public new static vtkDGVert SafeDownCast(vtkObjectBase o)
		{
			vtkDGVert vtkDGVert = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDGVert.vtkDGVert_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDGVert = (vtkDGVert)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDGVert.Register(null);
				}
			}
			return vtkDGVert;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040010AF RID: 4271
		public new const string MRFullTypeName = "Kitware.VTK.vtkDGVert";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040010B0 RID: 4272
		public new static readonly string MRClassNameKey = "class vtkDGVert";
	}
}

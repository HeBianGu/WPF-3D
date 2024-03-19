using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDGTet
	/// </summary>
	/// <remarks>
	///    Metadata for a discontinuous Galerkin tetrahedron.
	///
	/// Currently, only a linear shape is supported but this
	/// may change to arbitrary order.
	/// </remarks>
	// Token: 0x020004E4 RID: 1252
	public class vtkDGTet : vtkDeRhamCell
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600E267 RID: 57959 RVA: 0x0013AF47 File Offset: 0x00139147
		static vtkDGTet()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDGTet.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDGTet"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600E268 RID: 57960 RVA: 0x0013AF6F File Offset: 0x0013916F
		public vtkDGTet(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600E269 RID: 57961
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDGTet_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E26A RID: 57962 RVA: 0x0013AF80 File Offset: 0x00139180
		public new static vtkDGTet New()
		{
			vtkDGTet result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDGTet.vtkDGTet_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDGTet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E26B RID: 57963 RVA: 0x0013AFD4 File Offset: 0x001391D4
		public vtkDGTet() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDGTet.vtkDGTet_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600E26C RID: 57964 RVA: 0x0013B018 File Offset: 0x00139218
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600E26D RID: 57965
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDGTet_GetDimension_01(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E26E RID: 57966 RVA: 0x0013B024 File Offset: 0x00139224
		public override int GetDimension()
		{
			return vtkDGTet.vtkDGTet_GetDimension_01(base.GetCppThis());
		}

		// Token: 0x0600E26F RID: 57967
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDGTet_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E270 RID: 57968 RVA: 0x0013B044 File Offset: 0x00139244
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDGTet.vtkDGTet_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600E271 RID: 57969
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDGTet_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E272 RID: 57970 RVA: 0x0013B064 File Offset: 0x00139264
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDGTet.vtkDGTet_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600E273 RID: 57971
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDGTet_GetNumberOfSideTypes_04(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E274 RID: 57972 RVA: 0x0013B080 File Offset: 0x00139280
		public override int GetNumberOfSideTypes()
		{
			return vtkDGTet.vtkDGTet_GetNumberOfSideTypes_04(base.GetCppThis());
		}

		// Token: 0x0600E275 RID: 57973
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDGTet_GetNumberOfSidesOfDimension_05(HandleRef pThis, int dimension);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E276 RID: 57974 RVA: 0x0013B0A0 File Offset: 0x001392A0
		public override int GetNumberOfSidesOfDimension(int dimension)
		{
			return vtkDGTet.vtkDGTet_GetNumberOfSidesOfDimension_05(base.GetCppThis(), dimension);
		}

		// Token: 0x0600E277 RID: 57975
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDGTet_GetReferencePoints_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E278 RID: 57976 RVA: 0x0013B0C0 File Offset: 0x001392C0
		public override vtkTypeFloat32Array GetReferencePoints()
		{
			vtkTypeFloat32Array vtkTypeFloat32Array = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDGTet.vtkDGTet_GetReferencePoints_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600E279 RID: 57977
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkDGCell.Shape vtkDGTet_GetShape_07(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E27A RID: 57978 RVA: 0x0013B130 File Offset: 0x00139330
		public override vtkDGCell.Shape GetShape()
		{
			return vtkDGTet.vtkDGTet_GetShape_07(base.GetCppThis());
		}

		// Token: 0x0600E27B RID: 57979
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDGTet_GetSideConnectivity_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E27C RID: 57980 RVA: 0x0013B150 File Offset: 0x00139350
		public override vtkTypeInt32Array GetSideConnectivity()
		{
			vtkTypeInt32Array vtkTypeInt32Array = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDGTet.vtkDGTet_GetSideConnectivity_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600E27D RID: 57981
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDGTet_GetSideOffsetsAndShapes_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E27E RID: 57982 RVA: 0x0013B1C0 File Offset: 0x001393C0
		public override vtkTypeInt32Array GetSideOffsetsAndShapes()
		{
			vtkTypeInt32Array vtkTypeInt32Array = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDGTet.vtkDGTet_GetSideOffsetsAndShapes_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600E27F RID: 57983
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkDGCell.Shape vtkDGTet_GetSideShape_10(HandleRef pThis, int side);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E280 RID: 57984 RVA: 0x0013B230 File Offset: 0x00139430
		public override vtkDGCell.Shape GetSideShape(int side)
		{
			return vtkDGTet.vtkDGTet_GetSideShape_10(base.GetCppThis(), side);
		}

		// Token: 0x0600E281 RID: 57985
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDGTet_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E282 RID: 57986 RVA: 0x0013B250 File Offset: 0x00139450
		public override int IsA(string type)
		{
			return vtkDGTet.vtkDGTet_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x0600E283 RID: 57987
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDGTet_IsInside_12(HandleRef pThis, HandleRef rst, double tolerance);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E284 RID: 57988 RVA: 0x0013B270 File Offset: 0x00139470
		public override bool IsInside(vtkVector3d rst, double tolerance)
		{
			return vtkDGTet.vtkDGTet_IsInside_12(base.GetCppThis(), (rst == null) ? default(HandleRef) : rst.GetCppThis(), tolerance) != 0;
		}

		// Token: 0x0600E285 RID: 57989
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDGTet_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E286 RID: 57990 RVA: 0x0013B2AC File Offset: 0x001394AC
		public new static int IsTypeOf(string type)
		{
			return vtkDGTet.vtkDGTet_IsTypeOf_13(type);
		}

		// Token: 0x0600E287 RID: 57991
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDGTet_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E288 RID: 57992 RVA: 0x0013B2C8 File Offset: 0x001394C8
		public new vtkDGTet NewInstance()
		{
			vtkDGTet result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDGTet.vtkDGTet_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDGTet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600E289 RID: 57993
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDGTet_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E28A RID: 57994 RVA: 0x0013B324 File Offset: 0x00139524
		public new static vtkDGTet SafeDownCast(vtkObjectBase o)
		{
			vtkDGTet vtkDGTet = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDGTet.vtkDGTet_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDGTet = (vtkDGTet)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDGTet.Register(null);
				}
			}
			return vtkDGTet;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040010AB RID: 4267
		public new const string MRFullTypeName = "Kitware.VTK.vtkDGTet";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040010AC RID: 4268
		public new static readonly string MRClassNameKey = "class vtkDGTet";
	}
}

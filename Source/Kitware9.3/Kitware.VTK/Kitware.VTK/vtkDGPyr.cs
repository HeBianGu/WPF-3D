using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDGPyr
	/// </summary>
	/// <remarks>
	///    Metadata for a discontinuous Galerkin pyramid.
	///
	/// Currently, only a linear shape is supported but this
	/// may change to arbitrary order.
	/// </remarks>
	// Token: 0x020004E2 RID: 1250
	public class vtkDGPyr : vtkDGCell
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600E21F RID: 57887 RVA: 0x0013A68F File Offset: 0x0013888F
		static vtkDGPyr()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDGPyr.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDGPyr"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600E220 RID: 57888 RVA: 0x0013A6B7 File Offset: 0x001388B7
		public vtkDGPyr(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600E221 RID: 57889
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDGPyr_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E222 RID: 57890 RVA: 0x0013A6C8 File Offset: 0x001388C8
		public new static vtkDGPyr New()
		{
			vtkDGPyr result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDGPyr.vtkDGPyr_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDGPyr)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E223 RID: 57891 RVA: 0x0013A71C File Offset: 0x0013891C
		public vtkDGPyr() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDGPyr.vtkDGPyr_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600E224 RID: 57892 RVA: 0x0013A760 File Offset: 0x00138960
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600E225 RID: 57893
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDGPyr_GetDimension_01(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E226 RID: 57894 RVA: 0x0013A76C File Offset: 0x0013896C
		public override int GetDimension()
		{
			return vtkDGPyr.vtkDGPyr_GetDimension_01(base.GetCppThis());
		}

		// Token: 0x0600E227 RID: 57895
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDGPyr_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E228 RID: 57896 RVA: 0x0013A78C File Offset: 0x0013898C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDGPyr.vtkDGPyr_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600E229 RID: 57897
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDGPyr_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E22A RID: 57898 RVA: 0x0013A7AC File Offset: 0x001389AC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDGPyr.vtkDGPyr_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600E22B RID: 57899
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDGPyr_GetNumberOfSideTypes_04(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E22C RID: 57900 RVA: 0x0013A7C8 File Offset: 0x001389C8
		public override int GetNumberOfSideTypes()
		{
			return vtkDGPyr.vtkDGPyr_GetNumberOfSideTypes_04(base.GetCppThis());
		}

		// Token: 0x0600E22D RID: 57901
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDGPyr_GetNumberOfSidesOfDimension_05(HandleRef pThis, int dimension);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E22E RID: 57902 RVA: 0x0013A7E8 File Offset: 0x001389E8
		public override int GetNumberOfSidesOfDimension(int dimension)
		{
			return vtkDGPyr.vtkDGPyr_GetNumberOfSidesOfDimension_05(base.GetCppThis(), dimension);
		}

		// Token: 0x0600E22F RID: 57903
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDGPyr_GetReferencePoints_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E230 RID: 57904 RVA: 0x0013A808 File Offset: 0x00138A08
		public override vtkTypeFloat32Array GetReferencePoints()
		{
			vtkTypeFloat32Array vtkTypeFloat32Array = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDGPyr.vtkDGPyr_GetReferencePoints_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600E231 RID: 57905
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkDGCell.Shape vtkDGPyr_GetShape_07(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E232 RID: 57906 RVA: 0x0013A878 File Offset: 0x00138A78
		public override vtkDGCell.Shape GetShape()
		{
			return vtkDGPyr.vtkDGPyr_GetShape_07(base.GetCppThis());
		}

		// Token: 0x0600E233 RID: 57907
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDGPyr_GetSideConnectivity_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E234 RID: 57908 RVA: 0x0013A898 File Offset: 0x00138A98
		public override vtkTypeInt32Array GetSideConnectivity()
		{
			vtkTypeInt32Array vtkTypeInt32Array = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDGPyr.vtkDGPyr_GetSideConnectivity_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600E235 RID: 57909
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDGPyr_GetSideOffsetsAndShapes_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E236 RID: 57910 RVA: 0x0013A908 File Offset: 0x00138B08
		public override vtkTypeInt32Array GetSideOffsetsAndShapes()
		{
			vtkTypeInt32Array vtkTypeInt32Array = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDGPyr.vtkDGPyr_GetSideOffsetsAndShapes_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x0600E237 RID: 57911
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkDGCell.Shape vtkDGPyr_GetSideShape_10(HandleRef pThis, int side);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E238 RID: 57912 RVA: 0x0013A978 File Offset: 0x00138B78
		public override vtkDGCell.Shape GetSideShape(int side)
		{
			return vtkDGPyr.vtkDGPyr_GetSideShape_10(base.GetCppThis(), side);
		}

		// Token: 0x0600E239 RID: 57913
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDGPyr_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E23A RID: 57914 RVA: 0x0013A998 File Offset: 0x00138B98
		public override int IsA(string type)
		{
			return vtkDGPyr.vtkDGPyr_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x0600E23B RID: 57915
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkDGPyr_IsInside_12(HandleRef pThis, HandleRef rst, double tolerance);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E23C RID: 57916 RVA: 0x0013A9B8 File Offset: 0x00138BB8
		public override bool IsInside(vtkVector3d rst, double tolerance)
		{
			return vtkDGPyr.vtkDGPyr_IsInside_12(base.GetCppThis(), (rst == null) ? default(HandleRef) : rst.GetCppThis(), tolerance) != 0;
		}

		// Token: 0x0600E23D RID: 57917
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDGPyr_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E23E RID: 57918 RVA: 0x0013A9F4 File Offset: 0x00138BF4
		public new static int IsTypeOf(string type)
		{
			return vtkDGPyr.vtkDGPyr_IsTypeOf_13(type);
		}

		// Token: 0x0600E23F RID: 57919
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDGPyr_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E240 RID: 57920 RVA: 0x0013AA10 File Offset: 0x00138C10
		public new vtkDGPyr NewInstance()
		{
			vtkDGPyr result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDGPyr.vtkDGPyr_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDGPyr)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600E241 RID: 57921
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDGPyr_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E242 RID: 57922 RVA: 0x0013AA6C File Offset: 0x00138C6C
		public new static vtkDGPyr SafeDownCast(vtkObjectBase o)
		{
			vtkDGPyr vtkDGPyr = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDGPyr.vtkDGPyr_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDGPyr = (vtkDGPyr)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDGPyr.Register(null);
				}
			}
			return vtkDGPyr;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040010A7 RID: 4263
		public new const string MRFullTypeName = "Kitware.VTK.vtkDGPyr";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040010A8 RID: 4264
		public new static readonly string MRClassNameKey = "class vtkDGPyr";
	}
}

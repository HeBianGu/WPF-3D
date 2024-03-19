using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkStructuredPoints
	/// </summary>
	/// <remarks>
	///    A subclass of ImageData.
	///
	/// StructuredPoints is a subclass of ImageData that requires the data extent
	/// to exactly match the update extent. Normal image data allows that the
	/// data extent may be larger than the update extent.
	/// StructuredPoints also defines the origin differently that vtkImageData.
	/// For structured points the origin is the location of first point.
	/// Whereas images define the origin as the location of point 0, 0, 0.
	/// Image Origin is stored in ivar, and structured points
	/// have special methods for setting/getting the origin/extents.
	/// </remarks>
	// Token: 0x02000ACF RID: 2767
	public class vtkStructuredPoints : vtkImageData
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601D22F RID: 119343 RVA: 0x0029130B File Offset: 0x0028F50B
		static vtkStructuredPoints()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStructuredPoints.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStructuredPoints"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601D230 RID: 119344 RVA: 0x00291333 File Offset: 0x0028F533
		public vtkStructuredPoints(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601D231 RID: 119345
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredPoints_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D232 RID: 119346 RVA: 0x00291344 File Offset: 0x0028F544
		public new static vtkStructuredPoints New()
		{
			vtkStructuredPoints result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredPoints.vtkStructuredPoints_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStructuredPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D233 RID: 119347 RVA: 0x00291398 File Offset: 0x0028F598
		public vtkStructuredPoints() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkStructuredPoints.vtkStructuredPoints_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601D234 RID: 119348 RVA: 0x002913DC File Offset: 0x0028F5DC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601D235 RID: 119349
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStructuredPoints_GetDataObjectType_01(HandleRef pThis);

		/// <summary>
		/// To simplify filter superclasses,
		/// </summary>
		// Token: 0x0601D236 RID: 119350 RVA: 0x002913E8 File Offset: 0x0028F5E8
		public override int GetDataObjectType()
		{
			return vtkStructuredPoints.vtkStructuredPoints_GetDataObjectType_01(base.GetCppThis());
		}

		// Token: 0x0601D237 RID: 119351
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStructuredPoints_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D238 RID: 119352 RVA: 0x00291408 File Offset: 0x0028F608
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkStructuredPoints.vtkStructuredPoints_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0601D239 RID: 119353
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStructuredPoints_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D23A RID: 119354 RVA: 0x00291428 File Offset: 0x0028F628
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkStructuredPoints.vtkStructuredPoints_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601D23B RID: 119355
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStructuredPoints_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D23C RID: 119356 RVA: 0x00291444 File Offset: 0x0028F644
		public override int IsA(string type)
		{
			return vtkStructuredPoints.vtkStructuredPoints_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0601D23D RID: 119357
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStructuredPoints_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D23E RID: 119358 RVA: 0x00291464 File Offset: 0x0028F664
		public new static int IsTypeOf(string type)
		{
			return vtkStructuredPoints.vtkStructuredPoints_IsTypeOf_05(type);
		}

		// Token: 0x0601D23F RID: 119359
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredPoints_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D240 RID: 119360 RVA: 0x00291480 File Offset: 0x0028F680
		public new vtkStructuredPoints NewInstance()
		{
			vtkStructuredPoints result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredPoints.vtkStructuredPoints_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStructuredPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601D241 RID: 119361
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredPoints_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D242 RID: 119362 RVA: 0x002914DC File Offset: 0x0028F6DC
		public new static vtkStructuredPoints SafeDownCast(vtkObjectBase o)
		{
			vtkStructuredPoints vtkStructuredPoints = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredPoints.vtkStructuredPoints_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredPoints = (vtkStructuredPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredPoints.Register(null);
				}
			}
			return vtkStructuredPoints;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001EC4 RID: 7876
		public new const string MRFullTypeName = "Kitware.VTK.vtkStructuredPoints";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001EC5 RID: 7877
		public new static readonly string MRClassNameKey = "class vtkStructuredPoints";
	}
}

using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkStructuredExtent
	/// </summary>
	/// <remarks>
	///    helper class to aid working with structured
	///  extents.
	///
	///
	///  vtkStructuredExtent is an helper class that helps in arithmetic with
	///  structured extents. It defines a bunch of static methods (most of which are
	///  inlined) to aid in dealing with extents.
	/// </remarks>
	// Token: 0x02000ACD RID: 2765
	public class vtkStructuredExtent : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601D1A1 RID: 119201 RVA: 0x00290693 File Offset: 0x0028E893
		static vtkStructuredExtent()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStructuredExtent.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStructuredExtent"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601D1A2 RID: 119202 RVA: 0x002906BB File Offset: 0x0028E8BB
		public vtkStructuredExtent(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601D1A3 RID: 119203
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredExtent_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D1A4 RID: 119204 RVA: 0x002906CC File Offset: 0x0028E8CC
		public new static vtkStructuredExtent New()
		{
			vtkStructuredExtent result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredExtent.vtkStructuredExtent_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStructuredExtent)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D1A5 RID: 119205 RVA: 0x00290720 File Offset: 0x0028E920
		public vtkStructuredExtent() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkStructuredExtent.vtkStructuredExtent_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601D1A6 RID: 119206 RVA: 0x00290764 File Offset: 0x0028E964
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601D1A7 RID: 119207
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredExtent_Clamp_01(IntPtr ext, IntPtr wholeExt);

		/// <summary>
		/// Clamps \c ext to fit in \c wholeExt.
		/// </summary>
		// Token: 0x0601D1A8 RID: 119208 RVA: 0x0029076F File Offset: 0x0028E96F
		public static void Clamp(IntPtr ext, IntPtr wholeExt)
		{
			vtkStructuredExtent.vtkStructuredExtent_Clamp_01(ext, wholeExt);
		}

		// Token: 0x0601D1A9 RID: 119209
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredExtent_GetDimensions_02(IntPtr ext, IntPtr dims);

		/// <summary>
		/// Given the extents, computes the dimensions.
		/// </summary>
		// Token: 0x0601D1AA RID: 119210 RVA: 0x0029077A File Offset: 0x0028E97A
		public static void GetDimensions(IntPtr ext, IntPtr dims)
		{
			vtkStructuredExtent.vtkStructuredExtent_GetDimensions_02(ext, dims);
		}

		// Token: 0x0601D1AB RID: 119211
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStructuredExtent_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D1AC RID: 119212 RVA: 0x00290788 File Offset: 0x0028E988
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkStructuredExtent.vtkStructuredExtent_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0601D1AD RID: 119213
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStructuredExtent_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D1AE RID: 119214 RVA: 0x002907A8 File Offset: 0x0028E9A8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkStructuredExtent.vtkStructuredExtent_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0601D1AF RID: 119215
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredExtent_Grow_05(IntPtr ext, int count);

		/// <summary>
		/// Grows the \c ext on each side by the given \c count.
		/// </summary>
		// Token: 0x0601D1B0 RID: 119216 RVA: 0x002907C2 File Offset: 0x0028E9C2
		public static void Grow(IntPtr ext, int count)
		{
			vtkStructuredExtent.vtkStructuredExtent_Grow_05(ext, count);
		}

		// Token: 0x0601D1B1 RID: 119217
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredExtent_Grow_06(IntPtr ext, int count, IntPtr wholeExt);

		/// <summary>
		/// Grows the \c ext on each side by the given \c count
		/// while keeping it limited to the \c wholeExt.
		/// </summary>
		// Token: 0x0601D1B2 RID: 119218 RVA: 0x002907CD File Offset: 0x0028E9CD
		public static void Grow(IntPtr ext, int count, IntPtr wholeExt)
		{
			vtkStructuredExtent.vtkStructuredExtent_Grow_06(ext, count, wholeExt);
		}

		// Token: 0x0601D1B3 RID: 119219
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStructuredExtent_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D1B4 RID: 119220 RVA: 0x002907DC File Offset: 0x0028E9DC
		public override int IsA(string type)
		{
			return vtkStructuredExtent.vtkStructuredExtent_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0601D1B5 RID: 119221
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStructuredExtent_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D1B6 RID: 119222 RVA: 0x002907FC File Offset: 0x0028E9FC
		public new static int IsTypeOf(string type)
		{
			return vtkStructuredExtent.vtkStructuredExtent_IsTypeOf_08(type);
		}

		// Token: 0x0601D1B7 RID: 119223
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredExtent_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D1B8 RID: 119224 RVA: 0x00290818 File Offset: 0x0028EA18
		public new vtkStructuredExtent NewInstance()
		{
			vtkStructuredExtent result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredExtent.vtkStructuredExtent_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStructuredExtent)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601D1B9 RID: 119225
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStructuredExtent_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601D1BA RID: 119226 RVA: 0x00290874 File Offset: 0x0028EA74
		public new static vtkStructuredExtent SafeDownCast(vtkObjectBase o)
		{
			vtkStructuredExtent vtkStructuredExtent = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStructuredExtent.vtkStructuredExtent_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStructuredExtent = (vtkStructuredExtent)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStructuredExtent.Register(null);
				}
			}
			return vtkStructuredExtent;
		}

		// Token: 0x0601D1BB RID: 119227
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkStructuredExtent_Smaller_12(IntPtr ext, IntPtr wholeExt);

		/// <summary>
		/// Returns if \c ext fits within \c wholeExt. Unlike StrictlySmaller, this
		/// method returns true even if \c ext == \c wholeExt.
		/// </summary>
		// Token: 0x0601D1BC RID: 119228 RVA: 0x002908F4 File Offset: 0x0028EAF4
		public static bool Smaller(IntPtr ext, IntPtr wholeExt)
		{
			return vtkStructuredExtent.vtkStructuredExtent_Smaller_12(ext, wholeExt) != 0;
		}

		// Token: 0x0601D1BD RID: 119229
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkStructuredExtent_StrictlySmaller_13(IntPtr ext, IntPtr wholeExt);

		/// <summary>
		/// Returns true if \c ext is fits within \c wholeExt with at least 1 dimension
		/// smaller than the \c wholeExt.
		/// </summary>
		// Token: 0x0601D1BE RID: 119230 RVA: 0x00290918 File Offset: 0x0028EB18
		public static bool StrictlySmaller(IntPtr ext, IntPtr wholeExt)
		{
			return vtkStructuredExtent.vtkStructuredExtent_StrictlySmaller_13(ext, wholeExt) != 0;
		}

		// Token: 0x0601D1BF RID: 119231
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkStructuredExtent_Transform_14(IntPtr ext, IntPtr wholeExt);

		/// <summary>
		/// Makes \c ext relative to \c wholeExt.
		/// </summary>
		// Token: 0x0601D1C0 RID: 119232 RVA: 0x0029093A File Offset: 0x0028EB3A
		public static void Transform(IntPtr ext, IntPtr wholeExt)
		{
			vtkStructuredExtent.vtkStructuredExtent_Transform_14(ext, wholeExt);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001EC0 RID: 7872
		public new const string MRFullTypeName = "Kitware.VTK.vtkStructuredExtent";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001EC1 RID: 7873
		public new static readonly string MRClassNameKey = "class vtkStructuredExtent";
	}
}

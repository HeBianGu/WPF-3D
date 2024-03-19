using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageLuminance
	/// </summary>
	/// <remarks>
	///    Computes the luminance of the input
	///
	/// vtkImageLuminance calculates luminance from an rgb input.
	/// </remarks>
	// Token: 0x020003EF RID: 1007
	public class vtkImageLuminance : vtkThreadedImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600C0D1 RID: 49361 RVA: 0x0010C8C7 File Offset: 0x0010AAC7
		static vtkImageLuminance()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageLuminance.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageLuminance"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600C0D2 RID: 49362 RVA: 0x0010C8EF File Offset: 0x0010AAEF
		public vtkImageLuminance(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600C0D3 RID: 49363
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageLuminance_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C0D4 RID: 49364 RVA: 0x0010C900 File Offset: 0x0010AB00
		public new static vtkImageLuminance New()
		{
			vtkImageLuminance result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageLuminance.vtkImageLuminance_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageLuminance)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C0D5 RID: 49365 RVA: 0x0010C954 File Offset: 0x0010AB54
		public vtkImageLuminance() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageLuminance.vtkImageLuminance_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600C0D6 RID: 49366 RVA: 0x0010C998 File Offset: 0x0010AB98
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600C0D7 RID: 49367
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageLuminance_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C0D8 RID: 49368 RVA: 0x0010C9A4 File Offset: 0x0010ABA4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageLuminance.vtkImageLuminance_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600C0D9 RID: 49369
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageLuminance_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C0DA RID: 49370 RVA: 0x0010C9C4 File Offset: 0x0010ABC4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageLuminance.vtkImageLuminance_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600C0DB RID: 49371
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageLuminance_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C0DC RID: 49372 RVA: 0x0010C9E0 File Offset: 0x0010ABE0
		public override int IsA(string type)
		{
			return vtkImageLuminance.vtkImageLuminance_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600C0DD RID: 49373
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageLuminance_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C0DE RID: 49374 RVA: 0x0010CA00 File Offset: 0x0010AC00
		public new static int IsTypeOf(string type)
		{
			return vtkImageLuminance.vtkImageLuminance_IsTypeOf_04(type);
		}

		// Token: 0x0600C0DF RID: 49375
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageLuminance_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C0E0 RID: 49376 RVA: 0x0010CA1C File Offset: 0x0010AC1C
		public new vtkImageLuminance NewInstance()
		{
			vtkImageLuminance result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageLuminance.vtkImageLuminance_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageLuminance)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600C0E1 RID: 49377
		[DllImport("Kitware.VTK.ImagingColor.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageLuminance_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600C0E2 RID: 49378 RVA: 0x0010CA78 File Offset: 0x0010AC78
		public new static vtkImageLuminance SafeDownCast(vtkObjectBase o)
		{
			vtkImageLuminance vtkImageLuminance = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageLuminance.vtkImageLuminance_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageLuminance = (vtkImageLuminance)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageLuminance.Register(null);
				}
			}
			return vtkImageLuminance;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E4B RID: 3659
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageLuminance";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E4C RID: 3660
		public new static readonly string MRClassNameKey = "class vtkImageLuminance";
	}
}

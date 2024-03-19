using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageMagnitude.h
	/// </summary>
	/// <remarks>
	///    Colapses components with magnitude function.
	///
	/// vtkImageMagnitude takes the magnitude of the components.
	/// </remarks>
	// Token: 0x02000256 RID: 598
	public class vtkImageMagnitude : vtkThreadedImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06006E76 RID: 28278 RVA: 0x0009F501 File Offset: 0x0009D701
		static vtkImageMagnitude()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageMagnitude.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageMagnitude"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06006E77 RID: 28279 RVA: 0x0009F529 File Offset: 0x0009D729
		public vtkImageMagnitude(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06006E78 RID: 28280
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageMagnitude_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006E79 RID: 28281 RVA: 0x0009F538 File Offset: 0x0009D738
		public new static vtkImageMagnitude New()
		{
			vtkImageMagnitude result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageMagnitude.vtkImageMagnitude_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageMagnitude)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006E7A RID: 28282 RVA: 0x0009F58C File Offset: 0x0009D78C
		public vtkImageMagnitude() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageMagnitude.vtkImageMagnitude_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06006E7B RID: 28283 RVA: 0x0009F5D0 File Offset: 0x0009D7D0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06006E7C RID: 28284
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageMagnitude_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006E7D RID: 28285 RVA: 0x0009F5DC File Offset: 0x0009D7DC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageMagnitude.vtkImageMagnitude_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06006E7E RID: 28286
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageMagnitude_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006E7F RID: 28287 RVA: 0x0009F5FC File Offset: 0x0009D7FC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageMagnitude.vtkImageMagnitude_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06006E80 RID: 28288
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageMagnitude_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006E81 RID: 28289 RVA: 0x0009F618 File Offset: 0x0009D818
		public override int IsA(string type)
		{
			return vtkImageMagnitude.vtkImageMagnitude_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06006E82 RID: 28290
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageMagnitude_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006E83 RID: 28291 RVA: 0x0009F638 File Offset: 0x0009D838
		public new static int IsTypeOf(string type)
		{
			return vtkImageMagnitude.vtkImageMagnitude_IsTypeOf_04(type);
		}

		// Token: 0x06006E84 RID: 28292
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageMagnitude_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006E85 RID: 28293 RVA: 0x0009F654 File Offset: 0x0009D854
		public new vtkImageMagnitude NewInstance()
		{
			vtkImageMagnitude result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageMagnitude.vtkImageMagnitude_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageMagnitude)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06006E86 RID: 28294
		[DllImport("Kitware.VTK.ImagingMath.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageMagnitude_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006E87 RID: 28295 RVA: 0x0009F6B0 File Offset: 0x0009D8B0
		public new static vtkImageMagnitude SafeDownCast(vtkObjectBase o)
		{
			vtkImageMagnitude vtkImageMagnitude = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageMagnitude.vtkImageMagnitude_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageMagnitude = (vtkImageMagnitude)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageMagnitude.Register(null);
				}
			}
			return vtkImageMagnitude;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040009A1 RID: 2465
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageMagnitude";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040009A2 RID: 2466
		public new static readonly string MRClassNameKey = "class vtkImageMagnitude";
	}
}

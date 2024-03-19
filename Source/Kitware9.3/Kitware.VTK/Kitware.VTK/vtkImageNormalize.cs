using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageNormalize
	/// </summary>
	/// <remarks>
	///    Normalizes that scalar components for each point.
	///
	/// For each point, vtkImageNormalize normalizes the vector defined by the
	/// scalar components.  If the magnitude of this vector is zero, the output
	/// vector is zero also.
	/// </remarks>
	// Token: 0x0200048B RID: 1163
	public class vtkImageNormalize : vtkThreadedImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600D58D RID: 54669 RVA: 0x001292C1 File Offset: 0x001274C1
		static vtkImageNormalize()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageNormalize.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageNormalize"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600D58E RID: 54670 RVA: 0x001292E9 File Offset: 0x001274E9
		public vtkImageNormalize(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600D58F RID: 54671
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageNormalize_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D590 RID: 54672 RVA: 0x001292F8 File Offset: 0x001274F8
		public new static vtkImageNormalize New()
		{
			vtkImageNormalize result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageNormalize.vtkImageNormalize_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageNormalize)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D591 RID: 54673 RVA: 0x0012934C File Offset: 0x0012754C
		public vtkImageNormalize() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageNormalize.vtkImageNormalize_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600D592 RID: 54674 RVA: 0x00129390 File Offset: 0x00127590
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600D593 RID: 54675
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageNormalize_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D594 RID: 54676 RVA: 0x0012939C File Offset: 0x0012759C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageNormalize.vtkImageNormalize_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600D595 RID: 54677
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageNormalize_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D596 RID: 54678 RVA: 0x001293BC File Offset: 0x001275BC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageNormalize.vtkImageNormalize_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600D597 RID: 54679
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageNormalize_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D598 RID: 54680 RVA: 0x001293D8 File Offset: 0x001275D8
		public override int IsA(string type)
		{
			return vtkImageNormalize.vtkImageNormalize_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600D599 RID: 54681
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageNormalize_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D59A RID: 54682 RVA: 0x001293F8 File Offset: 0x001275F8
		public new static int IsTypeOf(string type)
		{
			return vtkImageNormalize.vtkImageNormalize_IsTypeOf_04(type);
		}

		// Token: 0x0600D59B RID: 54683
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageNormalize_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D59C RID: 54684 RVA: 0x00129414 File Offset: 0x00127614
		public new vtkImageNormalize NewInstance()
		{
			vtkImageNormalize result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageNormalize.vtkImageNormalize_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageNormalize)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600D59D RID: 54685
		[DllImport("Kitware.VTK.ImagingGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageNormalize_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D59E RID: 54686 RVA: 0x00129470 File Offset: 0x00127670
		public new static vtkImageNormalize SafeDownCast(vtkObjectBase o)
		{
			vtkImageNormalize vtkImageNormalize = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageNormalize.vtkImageNormalize_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageNormalize = (vtkImageNormalize)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageNormalize.Register(null);
				}
			}
			return vtkImageNormalize;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FBE RID: 4030
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageNormalize";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000FBF RID: 4031
		public new static readonly string MRClassNameKey = "class vtkImageNormalize";
	}
}

using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageDataStreamer
	/// </summary>
	/// <remarks>
	///    Initiates streaming on image data.
	///
	/// To satisfy a request, this filter calls update on its input
	/// many times with smaller update extents.  All processing up stream
	/// streams smaller pieces.
	/// </remarks>
	// Token: 0x0200046C RID: 1132
	public class vtkImageDataStreamer : vtkImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600D1DC RID: 53724 RVA: 0x00123F77 File Offset: 0x00122177
		static vtkImageDataStreamer()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageDataStreamer.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageDataStreamer"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600D1DD RID: 53725 RVA: 0x00123F9F File Offset: 0x0012219F
		public vtkImageDataStreamer(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600D1DE RID: 53726
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageDataStreamer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D1DF RID: 53727 RVA: 0x00123FB0 File Offset: 0x001221B0
		public new static vtkImageDataStreamer New()
		{
			vtkImageDataStreamer result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageDataStreamer.vtkImageDataStreamer_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageDataStreamer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D1E0 RID: 53728 RVA: 0x00124004 File Offset: 0x00122204
		public vtkImageDataStreamer() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageDataStreamer.vtkImageDataStreamer_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600D1E1 RID: 53729 RVA: 0x00124048 File Offset: 0x00122248
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600D1E2 RID: 53730
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageDataStreamer_GetExtentTranslator_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the extent translator that will be used to split the requests
		/// </summary>
		// Token: 0x0600D1E3 RID: 53731 RVA: 0x00124054 File Offset: 0x00122254
		public virtual vtkExtentTranslator GetExtentTranslator()
		{
			vtkExtentTranslator vtkExtentTranslator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageDataStreamer.vtkImageDataStreamer_GetExtentTranslator_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkExtentTranslator = (vtkExtentTranslator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkExtentTranslator.Register(null);
				}
			}
			return vtkExtentTranslator;
		}

		// Token: 0x0600D1E4 RID: 53732
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageDataStreamer_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D1E5 RID: 53733 RVA: 0x001240C4 File Offset: 0x001222C4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageDataStreamer.vtkImageDataStreamer_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600D1E6 RID: 53734
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageDataStreamer_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D1E7 RID: 53735 RVA: 0x001240E4 File Offset: 0x001222E4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageDataStreamer.vtkImageDataStreamer_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600D1E8 RID: 53736
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageDataStreamer_GetNumberOfStreamDivisions_04(HandleRef pThis);

		/// <summary>
		/// Set how many pieces to divide the input into.
		/// void SetNumberOfStreamDivisions(int num);
		/// int GetNumberOfStreamDivisions();
		/// </summary>
		// Token: 0x0600D1E9 RID: 53737 RVA: 0x00124100 File Offset: 0x00122300
		public virtual int GetNumberOfStreamDivisions()
		{
			return vtkImageDataStreamer.vtkImageDataStreamer_GetNumberOfStreamDivisions_04(base.GetCppThis());
		}

		// Token: 0x0600D1EA RID: 53738
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageDataStreamer_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D1EB RID: 53739 RVA: 0x00124120 File Offset: 0x00122320
		public override int IsA(string type)
		{
			return vtkImageDataStreamer.vtkImageDataStreamer_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0600D1EC RID: 53740
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageDataStreamer_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D1ED RID: 53741 RVA: 0x00124140 File Offset: 0x00122340
		public new static int IsTypeOf(string type)
		{
			return vtkImageDataStreamer.vtkImageDataStreamer_IsTypeOf_06(type);
		}

		// Token: 0x0600D1EE RID: 53742
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageDataStreamer_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D1EF RID: 53743 RVA: 0x0012415C File Offset: 0x0012235C
		public new vtkImageDataStreamer NewInstance()
		{
			vtkImageDataStreamer result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageDataStreamer.vtkImageDataStreamer_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageDataStreamer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600D1F0 RID: 53744
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageDataStreamer_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600D1F1 RID: 53745 RVA: 0x001241B8 File Offset: 0x001223B8
		public new static vtkImageDataStreamer SafeDownCast(vtkObjectBase o)
		{
			vtkImageDataStreamer vtkImageDataStreamer = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageDataStreamer.vtkImageDataStreamer_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageDataStreamer = (vtkImageDataStreamer)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageDataStreamer.Register(null);
				}
			}
			return vtkImageDataStreamer;
		}

		// Token: 0x0600D1F2 RID: 53746
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageDataStreamer_SetExtentTranslator_10(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Get the extent translator that will be used to split the requests
		/// </summary>
		// Token: 0x0600D1F3 RID: 53747 RVA: 0x00124238 File Offset: 0x00122438
		public virtual void SetExtentTranslator(vtkExtentTranslator arg0)
		{
			vtkImageDataStreamer.vtkImageDataStreamer_SetExtentTranslator_10(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0600D1F4 RID: 53748
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageDataStreamer_SetNumberOfStreamDivisions_11(HandleRef pThis, int _arg);

		/// <summary>
		/// Set how many pieces to divide the input into.
		/// void SetNumberOfStreamDivisions(int num);
		/// int GetNumberOfStreamDivisions();
		/// </summary>
		// Token: 0x0600D1F5 RID: 53749 RVA: 0x00124267 File Offset: 0x00122467
		public virtual void SetNumberOfStreamDivisions(int _arg)
		{
			vtkImageDataStreamer.vtkImageDataStreamer_SetNumberOfStreamDivisions_11(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F79 RID: 3961
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageDataStreamer";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000F7A RID: 3962
		public new static readonly string MRClassNameKey = "class vtkImageDataStreamer";
	}
}

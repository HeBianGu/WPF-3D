using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageConstantPad
	/// </summary>
	/// <remarks>
	///    Makes image larger by padding with constant.
	///
	/// vtkImageConstantPad changes the image extent of its input.
	/// Any pixels outside of the original image extent are filled with
	/// a constant value (default is 0.0).
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkImageWrapPad vtkImageMirrorPad
	/// </seealso>
	// Token: 0x02000856 RID: 2134
	public class vtkImageConstantPad : vtkImagePadFilter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601623A RID: 90682 RVA: 0x001F2ABB File Offset: 0x001F0CBB
		static vtkImageConstantPad()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageConstantPad.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageConstantPad"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601623B RID: 90683 RVA: 0x001F2AE3 File Offset: 0x001F0CE3
		public vtkImageConstantPad(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601623C RID: 90684
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageConstantPad_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601623D RID: 90685 RVA: 0x001F2AF4 File Offset: 0x001F0CF4
		public new static vtkImageConstantPad New()
		{
			vtkImageConstantPad result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageConstantPad.vtkImageConstantPad_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageConstantPad)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601623E RID: 90686 RVA: 0x001F2B48 File Offset: 0x001F0D48
		public vtkImageConstantPad() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageConstantPad.vtkImageConstantPad_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601623F RID: 90687 RVA: 0x001F2B8C File Offset: 0x001F0D8C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06016240 RID: 90688
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageConstantPad_GetConstant_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the pad value.
		/// </summary>
		// Token: 0x06016241 RID: 90689 RVA: 0x001F2B98 File Offset: 0x001F0D98
		public virtual double GetConstant()
		{
			return vtkImageConstantPad.vtkImageConstantPad_GetConstant_01(base.GetCppThis());
		}

		// Token: 0x06016242 RID: 90690
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageConstantPad_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016243 RID: 90691 RVA: 0x001F2BB8 File Offset: 0x001F0DB8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageConstantPad.vtkImageConstantPad_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06016244 RID: 90692
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageConstantPad_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016245 RID: 90693 RVA: 0x001F2BD8 File Offset: 0x001F0DD8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageConstantPad.vtkImageConstantPad_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06016246 RID: 90694
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageConstantPad_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016247 RID: 90695 RVA: 0x001F2BF4 File Offset: 0x001F0DF4
		public override int IsA(string type)
		{
			return vtkImageConstantPad.vtkImageConstantPad_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06016248 RID: 90696
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageConstantPad_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016249 RID: 90697 RVA: 0x001F2C14 File Offset: 0x001F0E14
		public new static int IsTypeOf(string type)
		{
			return vtkImageConstantPad.vtkImageConstantPad_IsTypeOf_05(type);
		}

		// Token: 0x0601624A RID: 90698
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageConstantPad_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601624B RID: 90699 RVA: 0x001F2C30 File Offset: 0x001F0E30
		public new vtkImageConstantPad NewInstance()
		{
			vtkImageConstantPad result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageConstantPad.vtkImageConstantPad_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageConstantPad)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601624C RID: 90700
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageConstantPad_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601624D RID: 90701 RVA: 0x001F2C8C File Offset: 0x001F0E8C
		public new static vtkImageConstantPad SafeDownCast(vtkObjectBase o)
		{
			vtkImageConstantPad vtkImageConstantPad = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageConstantPad.vtkImageConstantPad_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageConstantPad = (vtkImageConstantPad)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageConstantPad.Register(null);
				}
			}
			return vtkImageConstantPad;
		}

		// Token: 0x0601624E RID: 90702
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageConstantPad_SetConstant_09(HandleRef pThis, double _arg);

		/// <summary>
		/// Set/Get the pad value.
		/// </summary>
		// Token: 0x0601624F RID: 90703 RVA: 0x001F2D0B File Offset: 0x001F0F0B
		public virtual void SetConstant(double _arg)
		{
			vtkImageConstantPad.vtkImageConstantPad_SetConstant_09(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001900 RID: 6400
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageConstantPad";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001901 RID: 6401
		public new static readonly string MRClassNameKey = "class vtkImageConstantPad";
	}
}

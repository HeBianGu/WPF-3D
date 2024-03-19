using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkMedicalImageReader2
	/// </summary>
	/// <remarks>
	///    vtkImageReader2 with medical meta data.
	///
	/// vtkMedicalImageReader2 is a parent class for medical image readers.
	/// It provides a place to store patient information that may be stored
	/// in the image header.
	/// </remarks>
	/// <seealso>
	///
	/// vtkImageReader2 vtkGESignaReader vtkMedicalImageProperties
	/// </seealso>
	// Token: 0x02000761 RID: 1889
	public class vtkMedicalImageReader2 : vtkImageReader2
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060139E1 RID: 80353 RVA: 0x001BB993 File Offset: 0x001B9B93
		static vtkMedicalImageReader2()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMedicalImageReader2.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMedicalImageReader2"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060139E2 RID: 80354 RVA: 0x001BB9BB File Offset: 0x001B9BBB
		public vtkMedicalImageReader2(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060139E3 RID: 80355
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMedicalImageReader2_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060139E4 RID: 80356 RVA: 0x001BB9CC File Offset: 0x001B9BCC
		public new static vtkMedicalImageReader2 New()
		{
			vtkMedicalImageReader2 result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMedicalImageReader2.vtkMedicalImageReader2_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMedicalImageReader2)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060139E5 RID: 80357 RVA: 0x001BBA20 File Offset: 0x001B9C20
		public vtkMedicalImageReader2() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkMedicalImageReader2.vtkMedicalImageReader2_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060139E6 RID: 80358 RVA: 0x001BBA64 File Offset: 0x001B9C64
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060139E7 RID: 80359
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMedicalImageReader2_GetDate_01(HandleRef pThis);

		/// <summary>
		/// For backward compatibility, propagate calls to the MedicalImageProperties
		/// object.
		/// </summary>
		// Token: 0x060139E8 RID: 80360 RVA: 0x001BBA70 File Offset: 0x001B9C70
		public virtual string GetDate()
		{
			string s = Marshal.PtrToStringAnsi(vtkMedicalImageReader2.vtkMedicalImageReader2_GetDate_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060139E9 RID: 80361
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMedicalImageReader2_GetImageNumber_02(HandleRef pThis);

		/// <summary>
		/// For backward compatibility, propagate calls to the MedicalImageProperties
		/// object.
		/// </summary>
		// Token: 0x060139EA RID: 80362 RVA: 0x001BBAAC File Offset: 0x001B9CAC
		public virtual string GetImageNumber()
		{
			string s = Marshal.PtrToStringAnsi(vtkMedicalImageReader2.vtkMedicalImageReader2_GetImageNumber_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060139EB RID: 80363
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMedicalImageReader2_GetMedicalImageProperties_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the medical image properties object
		/// </summary>
		// Token: 0x060139EC RID: 80364 RVA: 0x001BBAE8 File Offset: 0x001B9CE8
		public virtual vtkMedicalImageProperties GetMedicalImageProperties()
		{
			vtkMedicalImageProperties vtkMedicalImageProperties = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMedicalImageReader2.vtkMedicalImageReader2_GetMedicalImageProperties_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMedicalImageProperties = (vtkMedicalImageProperties)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMedicalImageProperties.Register(null);
				}
			}
			return vtkMedicalImageProperties;
		}

		// Token: 0x060139ED RID: 80365
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMedicalImageReader2_GetModality_04(HandleRef pThis);

		/// <summary>
		/// For backward compatibility, propagate calls to the MedicalImageProperties
		/// object.
		/// </summary>
		// Token: 0x060139EE RID: 80366 RVA: 0x001BBB58 File Offset: 0x001B9D58
		public virtual string GetModality()
		{
			string s = Marshal.PtrToStringAnsi(vtkMedicalImageReader2.vtkMedicalImageReader2_GetModality_04(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060139EF RID: 80367
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMedicalImageReader2_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060139F0 RID: 80368 RVA: 0x001BBB94 File Offset: 0x001B9D94
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkMedicalImageReader2.vtkMedicalImageReader2_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x060139F1 RID: 80369
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkMedicalImageReader2_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060139F2 RID: 80370 RVA: 0x001BBBB4 File Offset: 0x001B9DB4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkMedicalImageReader2.vtkMedicalImageReader2_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x060139F3 RID: 80371
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMedicalImageReader2_GetPatientID_07(HandleRef pThis);

		/// <summary>
		/// For backward compatibility, propagate calls to the MedicalImageProperties
		/// object.
		/// </summary>
		// Token: 0x060139F4 RID: 80372 RVA: 0x001BBBD0 File Offset: 0x001B9DD0
		public virtual string GetPatientID()
		{
			string s = Marshal.PtrToStringAnsi(vtkMedicalImageReader2.vtkMedicalImageReader2_GetPatientID_07(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060139F5 RID: 80373
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMedicalImageReader2_GetPatientName_08(HandleRef pThis);

		/// <summary>
		/// For backward compatibility, propagate calls to the MedicalImageProperties
		/// object.
		/// </summary>
		// Token: 0x060139F6 RID: 80374 RVA: 0x001BBC0C File Offset: 0x001B9E0C
		public virtual string GetPatientName()
		{
			string s = Marshal.PtrToStringAnsi(vtkMedicalImageReader2.vtkMedicalImageReader2_GetPatientName_08(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060139F7 RID: 80375
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMedicalImageReader2_GetSeries_09(HandleRef pThis);

		/// <summary>
		/// For backward compatibility, propagate calls to the MedicalImageProperties
		/// object.
		/// </summary>
		// Token: 0x060139F8 RID: 80376 RVA: 0x001BBC48 File Offset: 0x001B9E48
		public virtual string GetSeries()
		{
			string s = Marshal.PtrToStringAnsi(vtkMedicalImageReader2.vtkMedicalImageReader2_GetSeries_09(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060139F9 RID: 80377
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMedicalImageReader2_GetStudy_10(HandleRef pThis);

		/// <summary>
		/// For backward compatibility, propagate calls to the MedicalImageProperties
		/// object.
		/// </summary>
		// Token: 0x060139FA RID: 80378 RVA: 0x001BBC84 File Offset: 0x001B9E84
		public virtual string GetStudy()
		{
			string s = Marshal.PtrToStringAnsi(vtkMedicalImageReader2.vtkMedicalImageReader2_GetStudy_10(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060139FB RID: 80379
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMedicalImageReader2_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060139FC RID: 80380 RVA: 0x001BBCC0 File Offset: 0x001B9EC0
		public override int IsA(string type)
		{
			return vtkMedicalImageReader2.vtkMedicalImageReader2_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x060139FD RID: 80381
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkMedicalImageReader2_IsTypeOf_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060139FE RID: 80382 RVA: 0x001BBCE0 File Offset: 0x001B9EE0
		public new static int IsTypeOf(string type)
		{
			return vtkMedicalImageReader2.vtkMedicalImageReader2_IsTypeOf_12(type);
		}

		// Token: 0x060139FF RID: 80383
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMedicalImageReader2_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013A00 RID: 80384 RVA: 0x001BBCFC File Offset: 0x001B9EFC
		public new vtkMedicalImageReader2 NewInstance()
		{
			vtkMedicalImageReader2 result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMedicalImageReader2.vtkMedicalImageReader2_NewInstance_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMedicalImageReader2)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06013A01 RID: 80385
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkMedicalImageReader2_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013A02 RID: 80386 RVA: 0x001BBD58 File Offset: 0x001B9F58
		public new static vtkMedicalImageReader2 SafeDownCast(vtkObjectBase o)
		{
			vtkMedicalImageReader2 vtkMedicalImageReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkMedicalImageReader2.vtkMedicalImageReader2_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMedicalImageReader = (vtkMedicalImageReader2)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMedicalImageReader.Register(null);
				}
			}
			return vtkMedicalImageReader;
		}

		// Token: 0x06013A03 RID: 80387
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMedicalImageReader2_SetDate_16(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// For backward compatibility, propagate calls to the MedicalImageProperties
		/// object.
		/// </summary>
		// Token: 0x06013A04 RID: 80388 RVA: 0x001BBDD7 File Offset: 0x001B9FD7
		public virtual void SetDate(string arg0)
		{
			vtkMedicalImageReader2.vtkMedicalImageReader2_SetDate_16(base.GetCppThis(), arg0);
		}

		// Token: 0x06013A05 RID: 80389
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMedicalImageReader2_SetImageNumber_17(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// For backward compatibility, propagate calls to the MedicalImageProperties
		/// object.
		/// </summary>
		// Token: 0x06013A06 RID: 80390 RVA: 0x001BBDE7 File Offset: 0x001B9FE7
		public virtual void SetImageNumber(string arg0)
		{
			vtkMedicalImageReader2.vtkMedicalImageReader2_SetImageNumber_17(base.GetCppThis(), arg0);
		}

		// Token: 0x06013A07 RID: 80391
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMedicalImageReader2_SetModality_18(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// For backward compatibility, propagate calls to the MedicalImageProperties
		/// object.
		/// </summary>
		// Token: 0x06013A08 RID: 80392 RVA: 0x001BBDF7 File Offset: 0x001B9FF7
		public virtual void SetModality(string arg0)
		{
			vtkMedicalImageReader2.vtkMedicalImageReader2_SetModality_18(base.GetCppThis(), arg0);
		}

		// Token: 0x06013A09 RID: 80393
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMedicalImageReader2_SetPatientID_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// For backward compatibility, propagate calls to the MedicalImageProperties
		/// object.
		/// </summary>
		// Token: 0x06013A0A RID: 80394 RVA: 0x001BBE07 File Offset: 0x001BA007
		public virtual void SetPatientID(string arg0)
		{
			vtkMedicalImageReader2.vtkMedicalImageReader2_SetPatientID_19(base.GetCppThis(), arg0);
		}

		// Token: 0x06013A0B RID: 80395
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMedicalImageReader2_SetPatientName_20(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// For backward compatibility, propagate calls to the MedicalImageProperties
		/// object.
		/// </summary>
		// Token: 0x06013A0C RID: 80396 RVA: 0x001BBE17 File Offset: 0x001BA017
		public virtual void SetPatientName(string arg0)
		{
			vtkMedicalImageReader2.vtkMedicalImageReader2_SetPatientName_20(base.GetCppThis(), arg0);
		}

		// Token: 0x06013A0D RID: 80397
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMedicalImageReader2_SetSeries_21(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// For backward compatibility, propagate calls to the MedicalImageProperties
		/// object.
		/// </summary>
		// Token: 0x06013A0E RID: 80398 RVA: 0x001BBE27 File Offset: 0x001BA027
		public virtual void SetSeries(string arg0)
		{
			vtkMedicalImageReader2.vtkMedicalImageReader2_SetSeries_21(base.GetCppThis(), arg0);
		}

		// Token: 0x06013A0F RID: 80399
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkMedicalImageReader2_SetStudy_22(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// For backward compatibility, propagate calls to the MedicalImageProperties
		/// object.
		/// </summary>
		// Token: 0x06013A10 RID: 80400 RVA: 0x001BBE37 File Offset: 0x001BA037
		public virtual void SetStudy(string arg0)
		{
			vtkMedicalImageReader2.vtkMedicalImageReader2_SetStudy_22(base.GetCppThis(), arg0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040016A0 RID: 5792
		public new const string MRFullTypeName = "Kitware.VTK.vtkMedicalImageReader2";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040016A1 RID: 5793
		public new static readonly string MRClassNameKey = "class vtkMedicalImageReader2";
	}
}

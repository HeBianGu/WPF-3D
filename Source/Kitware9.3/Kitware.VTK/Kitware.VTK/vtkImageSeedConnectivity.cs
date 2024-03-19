using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageSeedConnectivity
	/// </summary>
	/// <remarks>
	///    SeedConnectivity with user defined seeds.
	///
	/// vtkImageSeedConnectivity marks pixels connected to user supplied seeds.
	/// The input must be unsigned char, and the output is also unsigned char.  If
	/// a seed supplied by the user does not have pixel value "InputTrueValue",
	/// then the image is scanned +x, +y, +z until a pixel is encountered with
	/// value "InputTrueValue".  This new pixel is used as the seed .  Any pixel
	/// with out value "InputTrueValue" is consider off.  The output pixels values
	/// are 0 for any off pixel in input, "OutputTrueValue" for any pixels
	/// connected to seeds, and "OutputUnconnectedValue" for any on pixels not
	/// connected to seeds.  The same seeds are used for all images in the image
	/// set.
	/// </remarks>
	// Token: 0x0200024E RID: 590
	public class vtkImageSeedConnectivity : vtkImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06006D3F RID: 27967 RVA: 0x0009DAA1 File Offset: 0x0009BCA1
		static vtkImageSeedConnectivity()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageSeedConnectivity.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageSeedConnectivity"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06006D40 RID: 27968 RVA: 0x0009DAC9 File Offset: 0x0009BCC9
		public vtkImageSeedConnectivity(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06006D41 RID: 27969
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageSeedConnectivity_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006D42 RID: 27970 RVA: 0x0009DAD8 File Offset: 0x0009BCD8
		public new static vtkImageSeedConnectivity New()
		{
			vtkImageSeedConnectivity result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageSeedConnectivity.vtkImageSeedConnectivity_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageSeedConnectivity)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006D43 RID: 27971 RVA: 0x0009DB2C File Offset: 0x0009BD2C
		public vtkImageSeedConnectivity() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageSeedConnectivity.vtkImageSeedConnectivity_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06006D44 RID: 27972 RVA: 0x0009DB70 File Offset: 0x0009BD70
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06006D45 RID: 27973
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSeedConnectivity_AddSeed_01(HandleRef pThis, int num, IntPtr index);

		/// <summary>
		/// Methods for manipulating the seed pixels.
		/// </summary>
		// Token: 0x06006D46 RID: 27974 RVA: 0x0009DB7B File Offset: 0x0009BD7B
		public void AddSeed(int num, IntPtr index)
		{
			vtkImageSeedConnectivity.vtkImageSeedConnectivity_AddSeed_01(base.GetCppThis(), num, index);
		}

		// Token: 0x06006D47 RID: 27975
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSeedConnectivity_AddSeed_02(HandleRef pThis, int i0, int i1, int i2);

		/// <summary>
		/// Methods for manipulating the seed pixels.
		/// </summary>
		// Token: 0x06006D48 RID: 27976 RVA: 0x0009DB8C File Offset: 0x0009BD8C
		public void AddSeed(int i0, int i1, int i2)
		{
			vtkImageSeedConnectivity.vtkImageSeedConnectivity_AddSeed_02(base.GetCppThis(), i0, i1, i2);
		}

		// Token: 0x06006D49 RID: 27977
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSeedConnectivity_AddSeed_03(HandleRef pThis, int i0, int i1);

		/// <summary>
		/// Methods for manipulating the seed pixels.
		/// </summary>
		// Token: 0x06006D4A RID: 27978 RVA: 0x0009DB9E File Offset: 0x0009BD9E
		public void AddSeed(int i0, int i1)
		{
			vtkImageSeedConnectivity.vtkImageSeedConnectivity_AddSeed_03(base.GetCppThis(), i0, i1);
		}

		// Token: 0x06006D4B RID: 27979
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageSeedConnectivity_GetConnector_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the vtkImageCOnnector used by this filter.
		/// </summary>
		// Token: 0x06006D4C RID: 27980 RVA: 0x0009DBB0 File Offset: 0x0009BDB0
		public virtual vtkImageConnector GetConnector()
		{
			vtkImageConnector vtkImageConnector = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageSeedConnectivity.vtkImageSeedConnectivity_GetConnector_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageConnector = (vtkImageConnector)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageConnector.Register(null);
				}
			}
			return vtkImageConnector;
		}

		// Token: 0x06006D4D RID: 27981
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageSeedConnectivity_GetDimensionality_05(HandleRef pThis);

		/// <summary>
		/// Set the number of axes to use in connectivity.
		/// </summary>
		// Token: 0x06006D4E RID: 27982 RVA: 0x0009DC20 File Offset: 0x0009BE20
		public virtual int GetDimensionality()
		{
			return vtkImageSeedConnectivity.vtkImageSeedConnectivity_GetDimensionality_05(base.GetCppThis());
		}

		// Token: 0x06006D4F RID: 27983
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkImageSeedConnectivity_GetInputConnectValue_06(HandleRef pThis);

		/// <summary>
		/// Set/Get what value is considered as connecting pixels.
		/// </summary>
		// Token: 0x06006D50 RID: 27984 RVA: 0x0009DC40 File Offset: 0x0009BE40
		public virtual byte GetInputConnectValue()
		{
			return vtkImageSeedConnectivity.vtkImageSeedConnectivity_GetInputConnectValue_06(base.GetCppThis());
		}

		// Token: 0x06006D51 RID: 27985
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageSeedConnectivity_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006D52 RID: 27986 RVA: 0x0009DC60 File Offset: 0x0009BE60
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageSeedConnectivity.vtkImageSeedConnectivity_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x06006D53 RID: 27987
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageSeedConnectivity_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006D54 RID: 27988 RVA: 0x0009DC80 File Offset: 0x0009BE80
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageSeedConnectivity.vtkImageSeedConnectivity_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x06006D55 RID: 27989
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkImageSeedConnectivity_GetOutputConnectedValue_09(HandleRef pThis);

		/// <summary>
		/// Set/Get the value to set connected pixels to.
		/// </summary>
		// Token: 0x06006D56 RID: 27990 RVA: 0x0009DC9C File Offset: 0x0009BE9C
		public virtual byte GetOutputConnectedValue()
		{
			return vtkImageSeedConnectivity.vtkImageSeedConnectivity_GetOutputConnectedValue_09(base.GetCppThis());
		}

		// Token: 0x06006D57 RID: 27991
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkImageSeedConnectivity_GetOutputUnconnectedValue_10(HandleRef pThis);

		/// <summary>
		/// Set/Get the value to set unconnected pixels to.
		/// </summary>
		// Token: 0x06006D58 RID: 27992 RVA: 0x0009DCBC File Offset: 0x0009BEBC
		public virtual byte GetOutputUnconnectedValue()
		{
			return vtkImageSeedConnectivity.vtkImageSeedConnectivity_GetOutputUnconnectedValue_10(base.GetCppThis());
		}

		// Token: 0x06006D59 RID: 27993
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageSeedConnectivity_IsA_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006D5A RID: 27994 RVA: 0x0009DCDC File Offset: 0x0009BEDC
		public override int IsA(string type)
		{
			return vtkImageSeedConnectivity.vtkImageSeedConnectivity_IsA_11(base.GetCppThis(), type);
		}

		// Token: 0x06006D5B RID: 27995
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageSeedConnectivity_IsTypeOf_12([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006D5C RID: 27996 RVA: 0x0009DCFC File Offset: 0x0009BEFC
		public new static int IsTypeOf(string type)
		{
			return vtkImageSeedConnectivity.vtkImageSeedConnectivity_IsTypeOf_12(type);
		}

		// Token: 0x06006D5D RID: 27997
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageSeedConnectivity_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006D5E RID: 27998 RVA: 0x0009DD18 File Offset: 0x0009BF18
		public new vtkImageSeedConnectivity NewInstance()
		{
			vtkImageSeedConnectivity result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageSeedConnectivity.vtkImageSeedConnectivity_NewInstance_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageSeedConnectivity)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06006D5F RID: 27999
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSeedConnectivity_RemoveAllSeeds_15(HandleRef pThis);

		/// <summary>
		/// Methods for manipulating the seed pixels.
		/// </summary>
		// Token: 0x06006D60 RID: 28000 RVA: 0x0009DD72 File Offset: 0x0009BF72
		public void RemoveAllSeeds()
		{
			vtkImageSeedConnectivity.vtkImageSeedConnectivity_RemoveAllSeeds_15(base.GetCppThis());
		}

		// Token: 0x06006D61 RID: 28001
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageSeedConnectivity_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006D62 RID: 28002 RVA: 0x0009DD84 File Offset: 0x0009BF84
		public new static vtkImageSeedConnectivity SafeDownCast(vtkObjectBase o)
		{
			vtkImageSeedConnectivity vtkImageSeedConnectivity = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageSeedConnectivity.vtkImageSeedConnectivity_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageSeedConnectivity = (vtkImageSeedConnectivity)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageSeedConnectivity.Register(null);
				}
			}
			return vtkImageSeedConnectivity;
		}

		// Token: 0x06006D63 RID: 28003
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSeedConnectivity_SetDimensionality_17(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the number of axes to use in connectivity.
		/// </summary>
		// Token: 0x06006D64 RID: 28004 RVA: 0x0009DE03 File Offset: 0x0009C003
		public virtual void SetDimensionality(int _arg)
		{
			vtkImageSeedConnectivity.vtkImageSeedConnectivity_SetDimensionality_17(base.GetCppThis(), _arg);
		}

		// Token: 0x06006D65 RID: 28005
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSeedConnectivity_SetInputConnectValue_18(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get what value is considered as connecting pixels.
		/// </summary>
		// Token: 0x06006D66 RID: 28006 RVA: 0x0009DE13 File Offset: 0x0009C013
		public virtual void SetInputConnectValue(byte _arg)
		{
			vtkImageSeedConnectivity.vtkImageSeedConnectivity_SetInputConnectValue_18(base.GetCppThis(), _arg);
		}

		// Token: 0x06006D67 RID: 28007
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSeedConnectivity_SetOutputConnectedValue_19(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get the value to set connected pixels to.
		/// </summary>
		// Token: 0x06006D68 RID: 28008 RVA: 0x0009DE23 File Offset: 0x0009C023
		public virtual void SetOutputConnectedValue(byte _arg)
		{
			vtkImageSeedConnectivity.vtkImageSeedConnectivity_SetOutputConnectedValue_19(base.GetCppThis(), _arg);
		}

		// Token: 0x06006D69 RID: 28009
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageSeedConnectivity_SetOutputUnconnectedValue_20(HandleRef pThis, byte _arg);

		/// <summary>
		/// Set/Get the value to set unconnected pixels to.
		/// </summary>
		// Token: 0x06006D6A RID: 28010 RVA: 0x0009DE33 File Offset: 0x0009C033
		public virtual void SetOutputUnconnectedValue(byte _arg)
		{
			vtkImageSeedConnectivity.vtkImageSeedConnectivity_SetOutputUnconnectedValue_20(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000991 RID: 2449
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageSeedConnectivity";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000992 RID: 2450
		public new static readonly string MRClassNameKey = "class vtkImageSeedConnectivity";
	}
}

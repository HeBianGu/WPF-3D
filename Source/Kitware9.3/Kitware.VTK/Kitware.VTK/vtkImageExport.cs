using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageExport
	/// </summary>
	/// <remarks>
	///    Export VTK images to third-party systems.
	///
	/// vtkImageExport provides a way of exporting image data at the end
	/// of a pipeline to a third-party system or to a simple C array.
	/// Applications can use this to get direct access to the image data
	/// in memory.  A callback interface is provided to allow connection
	/// of the VTK pipeline to a third-party pipeline.  This interface
	/// conforms to the interface of vtkImageImport.
	/// In Python it is possible to use this class to write the image data
	/// into a python string that has been pre-allocated to be the correct
	/// size.
	/// </remarks>
	/// <seealso>
	///
	/// vtkImageImport
	/// </seealso>
	// Token: 0x02000765 RID: 1893
	public class vtkImageExport : vtkImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06013A49 RID: 80457 RVA: 0x001BC457 File Offset: 0x001BA657
		static vtkImageExport()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageExport.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageExport"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06013A4A RID: 80458 RVA: 0x001BC47F File Offset: 0x001BA67F
		public vtkImageExport(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06013A4B RID: 80459
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageExport_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013A4C RID: 80460 RVA: 0x001BC490 File Offset: 0x001BA690
		public new static vtkImageExport New()
		{
			vtkImageExport result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageExport.vtkImageExport_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageExport)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013A4D RID: 80461 RVA: 0x001BC4E4 File Offset: 0x001BA6E4
		public vtkImageExport() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageExport.vtkImageExport_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06013A4E RID: 80462 RVA: 0x001BC528 File Offset: 0x001BA728
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06013A4F RID: 80463
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageExport_Export_01(HandleRef pThis);

		/// <summary>
		/// The main interface: update the pipeline and export the image
		/// to the memory pointed to by SetExportVoidPointer().  You can
		/// also specify a void pointer when you call Export().
		/// </summary>
		// Token: 0x06013A50 RID: 80464 RVA: 0x001BC533 File Offset: 0x001BA733
		public void Export()
		{
			vtkImageExport.vtkImageExport_Export_01(base.GetCppThis());
		}

		// Token: 0x06013A51 RID: 80465
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageExport_Export_02(HandleRef pThis, IntPtr arg0);

		/// <summary>
		/// The main interface: update the pipeline and export the image
		/// to the memory pointed to by SetExportVoidPointer().  You can
		/// also specify a void pointer when you call Export().
		/// </summary>
		// Token: 0x06013A52 RID: 80466 RVA: 0x001BC542 File Offset: 0x001BA742
		public virtual void Export(IntPtr arg0)
		{
			vtkImageExport.vtkImageExport_Export_02(base.GetCppThis(), arg0);
		}

		// Token: 0x06013A53 RID: 80467
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkImageExport.BufferPointerCallbackType vtkImageExport_GetBufferPointerCallback_03(HandleRef pThis);

		/// <summary>
		/// Get pointers to the pipeline interface callbacks.
		/// </summary>
		// Token: 0x06013A54 RID: 80468 RVA: 0x001BC554 File Offset: 0x001BA754
		public vtkImageExport.BufferPointerCallbackType GetBufferPointerCallback()
		{
			return vtkImageExport.vtkImageExport_GetBufferPointerCallback_03(base.GetCppThis());
		}

		// Token: 0x06013A55 RID: 80469
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageExport_GetCallbackUserData_04(HandleRef pThis);

		/// <summary>
		/// Get the user data that should be passed to the callback functions.
		/// </summary>
		// Token: 0x06013A56 RID: 80470 RVA: 0x001BC574 File Offset: 0x001BA774
		public IntPtr GetCallbackUserData()
		{
			return vtkImageExport.vtkImageExport_GetCallbackUserData_04(base.GetCppThis());
		}

		// Token: 0x06013A57 RID: 80471
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageExport_GetDataDimensions_05(HandleRef pThis, IntPtr ptr);

		/// <summary>
		/// Get the (x,y,z) index dimensions of the data.  Please note
		/// that C arrays are indexed in decreasing order, i.e. array[z][y][x].
		/// </summary>
		// Token: 0x06013A58 RID: 80472 RVA: 0x001BC593 File Offset: 0x001BA793
		public void GetDataDimensions(IntPtr ptr)
		{
			vtkImageExport.vtkImageExport_GetDataDimensions_05(base.GetCppThis(), ptr);
		}

		// Token: 0x06013A59 RID: 80473
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageExport_GetDataDimensions_06(HandleRef pThis);

		/// <summary>
		/// Get the (x,y,z) index dimensions of the data.  Please note
		/// that C arrays are indexed in decreasing order, i.e. array[z][y][x].
		/// </summary>
		// Token: 0x06013A5A RID: 80474 RVA: 0x001BC5A4 File Offset: 0x001BA7A4
		public int[] GetDataDimensions()
		{
			IntPtr intPtr = vtkImageExport.vtkImageExport_GetDataDimensions_06(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06013A5B RID: 80475
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageExport_GetDataDirection_07(HandleRef pThis);

		/// <summary>
		/// Get miscellaneous additional information about the data.
		/// </summary>
		// Token: 0x06013A5C RID: 80476 RVA: 0x001BC5EC File Offset: 0x001BA7EC
		public IntPtr GetDataDirection()
		{
			return vtkImageExport.vtkImageExport_GetDataDirection_07(base.GetCppThis());
		}

		// Token: 0x06013A5D RID: 80477
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageExport_GetDataDirection_08(HandleRef pThis, IntPtr ptr);

		/// <summary>
		/// Get miscellaneous additional information about the data.
		/// </summary>
		// Token: 0x06013A5E RID: 80478 RVA: 0x001BC60B File Offset: 0x001BA80B
		public void GetDataDirection(IntPtr ptr)
		{
			vtkImageExport.vtkImageExport_GetDataDirection_08(base.GetCppThis(), ptr);
		}

		// Token: 0x06013A5F RID: 80479
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageExport_GetDataExtent_09(HandleRef pThis);

		/// <summary>
		/// Get miscellaneous additional information about the data.
		/// </summary>
		// Token: 0x06013A60 RID: 80480 RVA: 0x001BC61C File Offset: 0x001BA81C
		public int[] GetDataExtent()
		{
			IntPtr intPtr = vtkImageExport.vtkImageExport_GetDataExtent_09(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06013A61 RID: 80481
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageExport_GetDataExtent_10(HandleRef pThis, IntPtr ptr);

		/// <summary>
		/// Get miscellaneous additional information about the data.
		/// </summary>
		// Token: 0x06013A62 RID: 80482 RVA: 0x001BC664 File Offset: 0x001BA864
		public void GetDataExtent(IntPtr ptr)
		{
			vtkImageExport.vtkImageExport_GetDataExtent_10(base.GetCppThis(), ptr);
		}

		// Token: 0x06013A63 RID: 80483
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkImageExport.DataExtentCallbackType vtkImageExport_GetDataExtentCallback_11(HandleRef pThis);

		/// <summary>
		/// Get pointers to the pipeline interface callbacks.
		/// </summary>
		// Token: 0x06013A64 RID: 80484 RVA: 0x001BC674 File Offset: 0x001BA874
		public vtkImageExport.DataExtentCallbackType GetDataExtentCallback()
		{
			return vtkImageExport.vtkImageExport_GetDataExtentCallback_11(base.GetCppThis());
		}

		// Token: 0x06013A65 RID: 80485
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageExport_GetDataMemorySize_12(HandleRef pThis);

		/// <summary>
		/// Get the number of bytes required for the output C array.
		/// </summary>
		// Token: 0x06013A66 RID: 80486 RVA: 0x001BC694 File Offset: 0x001BA894
		public long GetDataMemorySize()
		{
			return vtkImageExport.vtkImageExport_GetDataMemorySize_12(base.GetCppThis());
		}

		// Token: 0x06013A67 RID: 80487
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageExport_GetDataNumberOfScalarComponents_13(HandleRef pThis);

		/// <summary>
		/// Get the number of scalar components of the data.  Please note that
		/// when you index into a C array, the scalar component index comes
		/// last, i.e. array[z][y][x][c].
		/// </summary>
		// Token: 0x06013A68 RID: 80488 RVA: 0x001BC6B4 File Offset: 0x001BA8B4
		public int GetDataNumberOfScalarComponents()
		{
			return vtkImageExport.vtkImageExport_GetDataNumberOfScalarComponents_13(base.GetCppThis());
		}

		// Token: 0x06013A69 RID: 80489
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageExport_GetDataOrigin_14(HandleRef pThis);

		/// <summary>
		/// Get miscellaneous additional information about the data.
		/// </summary>
		// Token: 0x06013A6A RID: 80490 RVA: 0x001BC6D4 File Offset: 0x001BA8D4
		public double[] GetDataOrigin()
		{
			IntPtr intPtr = vtkImageExport.vtkImageExport_GetDataOrigin_14(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06013A6B RID: 80491
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageExport_GetDataOrigin_15(HandleRef pThis, IntPtr ptr);

		/// <summary>
		/// Get miscellaneous additional information about the data.
		/// </summary>
		// Token: 0x06013A6C RID: 80492 RVA: 0x001BC71C File Offset: 0x001BA91C
		public void GetDataOrigin(IntPtr ptr)
		{
			vtkImageExport.vtkImageExport_GetDataOrigin_15(base.GetCppThis(), ptr);
		}

		// Token: 0x06013A6D RID: 80493
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageExport_GetDataScalarType_16(HandleRef pThis);

		/// <summary>
		/// Get the scalar type of the data.  The scalar type of the C array
		/// must match the scalar type of the data.
		/// </summary>
		// Token: 0x06013A6E RID: 80494 RVA: 0x001BC72C File Offset: 0x001BA92C
		public int GetDataScalarType()
		{
			return vtkImageExport.vtkImageExport_GetDataScalarType_16(base.GetCppThis());
		}

		// Token: 0x06013A6F RID: 80495
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageExport_GetDataScalarTypeAsString_17(HandleRef pThis);

		/// <summary>
		/// Get the scalar type of the data.  The scalar type of the C array
		/// must match the scalar type of the data.
		/// </summary>
		// Token: 0x06013A70 RID: 80496 RVA: 0x001BC74C File Offset: 0x001BA94C
		public string GetDataScalarTypeAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkImageExport.vtkImageExport_GetDataScalarTypeAsString_17(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013A71 RID: 80497
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageExport_GetDataSpacing_18(HandleRef pThis);

		/// <summary>
		/// Get miscellaneous additional information about the data.
		/// </summary>
		// Token: 0x06013A72 RID: 80498 RVA: 0x001BC788 File Offset: 0x001BA988
		public double[] GetDataSpacing()
		{
			IntPtr intPtr = vtkImageExport.vtkImageExport_GetDataSpacing_18(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06013A73 RID: 80499
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageExport_GetDataSpacing_19(HandleRef pThis, IntPtr ptr);

		/// <summary>
		/// Get miscellaneous additional information about the data.
		/// </summary>
		// Token: 0x06013A74 RID: 80500 RVA: 0x001BC7D0 File Offset: 0x001BA9D0
		public void GetDataSpacing(IntPtr ptr)
		{
			vtkImageExport.vtkImageExport_GetDataSpacing_19(base.GetCppThis(), ptr);
		}

		// Token: 0x06013A75 RID: 80501
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkImageExport.DirectionCallbackType vtkImageExport_GetDirectionCallback_20(HandleRef pThis);

		/// <summary>
		/// Get pointers to the pipeline interface callbacks.
		/// </summary>
		// Token: 0x06013A76 RID: 80502 RVA: 0x001BC7E0 File Offset: 0x001BA9E0
		public vtkImageExport.DirectionCallbackType GetDirectionCallback()
		{
			return vtkImageExport.vtkImageExport_GetDirectionCallback_20(base.GetCppThis());
		}

		// Token: 0x06013A77 RID: 80503
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageExport_GetExportVoidPointer_21(HandleRef pThis);

		/// <summary>
		/// Set the void pointer of the C array to export the data to.
		/// From python, you can specify a pointer to a string that is
		/// large enough to hold the data.
		/// </summary>
		// Token: 0x06013A78 RID: 80504 RVA: 0x001BC800 File Offset: 0x001BAA00
		public IntPtr GetExportVoidPointer()
		{
			return vtkImageExport.vtkImageExport_GetExportVoidPointer_21(base.GetCppThis());
		}

		// Token: 0x06013A79 RID: 80505
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageExport_GetImageLowerLeft_22(HandleRef pThis);

		/// <summary>
		/// Set/Get whether the data goes to the exported memory starting
		/// in the lower left corner or upper left corner.  Default: On.
		/// When this flag is Off, the image will be flipped vertically
		/// before it is exported.
		/// WARNING: this flag is used only with the Export() method,
		/// it is ignored by GetPointerToData().
		/// </summary>
		// Token: 0x06013A7A RID: 80506 RVA: 0x001BC820 File Offset: 0x001BAA20
		public virtual int GetImageLowerLeft()
		{
			return vtkImageExport.vtkImageExport_GetImageLowerLeft_22(base.GetCppThis());
		}

		// Token: 0x06013A7B RID: 80507
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageExport_GetInput_23(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the input object from the image pipeline.
		/// </summary>
		// Token: 0x06013A7C RID: 80508 RVA: 0x001BC840 File Offset: 0x001BAA40
		public new vtkImageData GetInput()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageExport.vtkImageExport_GetInput_23(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		// Token: 0x06013A7D RID: 80509
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkImageExport.NumberOfComponentsCallbackType vtkImageExport_GetNumberOfComponentsCallback_24(HandleRef pThis);

		/// <summary>
		/// Get pointers to the pipeline interface callbacks.
		/// </summary>
		// Token: 0x06013A7E RID: 80510 RVA: 0x001BC8B0 File Offset: 0x001BAAB0
		public vtkImageExport.NumberOfComponentsCallbackType GetNumberOfComponentsCallback()
		{
			return vtkImageExport.vtkImageExport_GetNumberOfComponentsCallback_24(base.GetCppThis());
		}

		// Token: 0x06013A7F RID: 80511
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageExport_GetNumberOfGenerationsFromBase_25(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013A80 RID: 80512 RVA: 0x001BC8D0 File Offset: 0x001BAAD0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageExport.vtkImageExport_GetNumberOfGenerationsFromBase_25(base.GetCppThis(), type);
		}

		// Token: 0x06013A81 RID: 80513
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageExport_GetNumberOfGenerationsFromBaseType_26([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013A82 RID: 80514 RVA: 0x001BC8F0 File Offset: 0x001BAAF0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageExport.vtkImageExport_GetNumberOfGenerationsFromBaseType_26(type);
		}

		// Token: 0x06013A83 RID: 80515
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkImageExport.DirectionCallbackType vtkImageExport_GetOriginCallback_27(HandleRef pThis);

		/// <summary>
		/// Get pointers to the pipeline interface callbacks.
		/// </summary>
		// Token: 0x06013A84 RID: 80516 RVA: 0x001BC90C File Offset: 0x001BAB0C
		public vtkImageExport.DirectionCallbackType GetOriginCallback()
		{
			return vtkImageExport.vtkImageExport_GetOriginCallback_27(base.GetCppThis());
		}

		// Token: 0x06013A85 RID: 80517
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkImageExport.NumberOfComponentsCallbackType vtkImageExport_GetPipelineModifiedCallback_28(HandleRef pThis);

		/// <summary>
		/// Get pointers to the pipeline interface callbacks.
		/// </summary>
		// Token: 0x06013A86 RID: 80518 RVA: 0x001BC92C File Offset: 0x001BAB2C
		public vtkImageExport.NumberOfComponentsCallbackType GetPipelineModifiedCallback()
		{
			return vtkImageExport.vtkImageExport_GetPipelineModifiedCallback_28(base.GetCppThis());
		}

		// Token: 0x06013A87 RID: 80519
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageExport_GetPointerToData_29(HandleRef pThis);

		/// <summary>
		/// An alternative to Export(): Use with caution.   Update the
		/// pipeline and return a pointer to the image memory.  The
		/// pointer is only valid until the next time that the pipeline
		/// is updated.
		/// WARNING: This method ignores the ImageLowerLeft flag.
		/// </summary>
		// Token: 0x06013A88 RID: 80520 RVA: 0x001BC94C File Offset: 0x001BAB4C
		public IntPtr GetPointerToData()
		{
			return vtkImageExport.vtkImageExport_GetPointerToData_29(base.GetCppThis());
		}

		// Token: 0x06013A89 RID: 80521
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkImageExport.PropagateUpdateExtentCallbackType vtkImageExport_GetPropagateUpdateExtentCallback_30(HandleRef pThis);

		/// <summary>
		/// Get pointers to the pipeline interface callbacks.
		/// </summary>
		// Token: 0x06013A8A RID: 80522 RVA: 0x001BC96C File Offset: 0x001BAB6C
		public vtkImageExport.PropagateUpdateExtentCallbackType GetPropagateUpdateExtentCallback()
		{
			return vtkImageExport.vtkImageExport_GetPropagateUpdateExtentCallback_30(base.GetCppThis());
		}

		// Token: 0x06013A8B RID: 80523
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkImageExport.ScalarTypeCallbackType vtkImageExport_GetScalarTypeCallback_31(HandleRef pThis);

		/// <summary>
		/// Get pointers to the pipeline interface callbacks.
		/// </summary>
		// Token: 0x06013A8C RID: 80524 RVA: 0x001BC98C File Offset: 0x001BAB8C
		public vtkImageExport.ScalarTypeCallbackType GetScalarTypeCallback()
		{
			return vtkImageExport.vtkImageExport_GetScalarTypeCallback_31(base.GetCppThis());
		}

		// Token: 0x06013A8D RID: 80525
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkImageExport.DirectionCallbackType vtkImageExport_GetSpacingCallback_32(HandleRef pThis);

		/// <summary>
		/// Get pointers to the pipeline interface callbacks.
		/// </summary>
		// Token: 0x06013A8E RID: 80526 RVA: 0x001BC9AC File Offset: 0x001BABAC
		public vtkImageExport.DirectionCallbackType GetSpacingCallback()
		{
			return vtkImageExport.vtkImageExport_GetSpacingCallback_32(base.GetCppThis());
		}

		// Token: 0x06013A8F RID: 80527
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkImageExport.UpdateDataCallbackType vtkImageExport_GetUpdateDataCallback_33(HandleRef pThis);

		/// <summary>
		/// Get pointers to the pipeline interface callbacks.
		/// </summary>
		// Token: 0x06013A90 RID: 80528 RVA: 0x001BC9CC File Offset: 0x001BABCC
		public vtkImageExport.UpdateDataCallbackType GetUpdateDataCallback()
		{
			return vtkImageExport.vtkImageExport_GetUpdateDataCallback_33(base.GetCppThis());
		}

		// Token: 0x06013A91 RID: 80529
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkImageExport.UpdateDataCallbackType vtkImageExport_GetUpdateInformationCallback_34(HandleRef pThis);

		/// <summary>
		/// Get pointers to the pipeline interface callbacks.
		/// </summary>
		// Token: 0x06013A92 RID: 80530 RVA: 0x001BC9EC File Offset: 0x001BABEC
		public vtkImageExport.UpdateDataCallbackType GetUpdateInformationCallback()
		{
			return vtkImageExport.vtkImageExport_GetUpdateInformationCallback_34(base.GetCppThis());
		}

		// Token: 0x06013A93 RID: 80531
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkImageExport.DataExtentCallbackType vtkImageExport_GetWholeExtentCallback_35(HandleRef pThis);

		/// <summary>
		/// Get pointers to the pipeline interface callbacks.
		/// </summary>
		// Token: 0x06013A94 RID: 80532 RVA: 0x001BCA0C File Offset: 0x001BAC0C
		public vtkImageExport.DataExtentCallbackType GetWholeExtentCallback()
		{
			return vtkImageExport.vtkImageExport_GetWholeExtentCallback_35(base.GetCppThis());
		}

		// Token: 0x06013A95 RID: 80533
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageExport_ImageLowerLeftOff_36(HandleRef pThis);

		/// <summary>
		/// Set/Get whether the data goes to the exported memory starting
		/// in the lower left corner or upper left corner.  Default: On.
		/// When this flag is Off, the image will be flipped vertically
		/// before it is exported.
		/// WARNING: this flag is used only with the Export() method,
		/// it is ignored by GetPointerToData().
		/// </summary>
		// Token: 0x06013A96 RID: 80534 RVA: 0x001BCA2B File Offset: 0x001BAC2B
		public virtual void ImageLowerLeftOff()
		{
			vtkImageExport.vtkImageExport_ImageLowerLeftOff_36(base.GetCppThis());
		}

		// Token: 0x06013A97 RID: 80535
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageExport_ImageLowerLeftOn_37(HandleRef pThis);

		/// <summary>
		/// Set/Get whether the data goes to the exported memory starting
		/// in the lower left corner or upper left corner.  Default: On.
		/// When this flag is Off, the image will be flipped vertically
		/// before it is exported.
		/// WARNING: this flag is used only with the Export() method,
		/// it is ignored by GetPointerToData().
		/// </summary>
		// Token: 0x06013A98 RID: 80536 RVA: 0x001BCA3A File Offset: 0x001BAC3A
		public virtual void ImageLowerLeftOn()
		{
			vtkImageExport.vtkImageExport_ImageLowerLeftOn_37(base.GetCppThis());
		}

		// Token: 0x06013A99 RID: 80537
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageExport_IsA_38(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013A9A RID: 80538 RVA: 0x001BCA4C File Offset: 0x001BAC4C
		public override int IsA(string type)
		{
			return vtkImageExport.vtkImageExport_IsA_38(base.GetCppThis(), type);
		}

		// Token: 0x06013A9B RID: 80539
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageExport_IsTypeOf_39([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013A9C RID: 80540 RVA: 0x001BCA6C File Offset: 0x001BAC6C
		public new static int IsTypeOf(string type)
		{
			return vtkImageExport.vtkImageExport_IsTypeOf_39(type);
		}

		// Token: 0x06013A9D RID: 80541
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageExport_NewInstance_41(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013A9E RID: 80542 RVA: 0x001BCA88 File Offset: 0x001BAC88
		public new vtkImageExport NewInstance()
		{
			vtkImageExport result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageExport.vtkImageExport_NewInstance_41(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageExport)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06013A9F RID: 80543
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageExport_SafeDownCast_42(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013AA0 RID: 80544 RVA: 0x001BCAE4 File Offset: 0x001BACE4
		public new static vtkImageExport SafeDownCast(vtkObjectBase o)
		{
			vtkImageExport vtkImageExport = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageExport.vtkImageExport_SafeDownCast_42((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageExport = (vtkImageExport)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageExport.Register(null);
				}
			}
			return vtkImageExport;
		}

		// Token: 0x06013AA1 RID: 80545
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageExport_SetExportVoidPointer_43(HandleRef pThis, IntPtr arg0);

		/// <summary>
		/// Set the void pointer of the C array to export the data to.
		/// From python, you can specify a pointer to a string that is
		/// large enough to hold the data.
		/// </summary>
		// Token: 0x06013AA2 RID: 80546 RVA: 0x001BCB63 File Offset: 0x001BAD63
		public void SetExportVoidPointer(IntPtr arg0)
		{
			vtkImageExport.vtkImageExport_SetExportVoidPointer_43(base.GetCppThis(), arg0);
		}

		// Token: 0x06013AA3 RID: 80547
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageExport_SetImageLowerLeft_44(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/Get whether the data goes to the exported memory starting
		/// in the lower left corner or upper left corner.  Default: On.
		/// When this flag is Off, the image will be flipped vertically
		/// before it is exported.
		/// WARNING: this flag is used only with the Export() method,
		/// it is ignored by GetPointerToData().
		/// </summary>
		// Token: 0x06013AA4 RID: 80548 RVA: 0x001BCB73 File Offset: 0x001BAD73
		public virtual void SetImageLowerLeft(int _arg)
		{
			vtkImageExport.vtkImageExport_SetImageLowerLeft_44(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040016A9 RID: 5801
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageExport";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040016AA RID: 5802
		public new static readonly string MRClassNameKey = "class vtkImageExport";

		/// <summary>
		/// These are function pointer types for the pipeline connection
		/// callbacks.  See further documentation in vtkImageImport.h.
		/// </summary>
		// Token: 0x02000766 RID: 1894
		// (Invoke) Token: 0x06013AA6 RID: 80550
		public delegate IntPtr BufferPointerCallbackType(IntPtr arg0);

		/// <summary>
		/// These are function pointer types for the pipeline connection
		/// callbacks.  See further documentation in vtkImageImport.h.
		/// </summary>
		// Token: 0x02000767 RID: 1895
		// (Invoke) Token: 0x06013AAA RID: 80554
		public delegate IntPtr DataExtentCallbackType(IntPtr arg0);

		/// <summary>
		/// These are function pointer types for the pipeline connection
		/// callbacks.  See further documentation in vtkImageImport.h.
		/// </summary>
		// Token: 0x02000768 RID: 1896
		// (Invoke) Token: 0x06013AAE RID: 80558
		public delegate IntPtr DirectionCallbackType(IntPtr arg0);

		/// <summary>
		/// These are function pointer types for the pipeline connection
		/// callbacks.  See further documentation in vtkImageImport.h.
		/// </summary>
		// Token: 0x02000769 RID: 1897
		// (Invoke) Token: 0x06013AB2 RID: 80562
		public delegate int NumberOfComponentsCallbackType(IntPtr arg0);

		/// <summary>
		/// These are function pointer types for the pipeline connection
		/// callbacks.  See further documentation in vtkImageImport.h.
		/// </summary>
		// Token: 0x0200076A RID: 1898
		// (Invoke) Token: 0x06013AB6 RID: 80566
		public delegate IntPtr OriginCallbackType(IntPtr arg0);

		/// <summary>
		/// These are function pointer types for the pipeline connection
		/// callbacks.  See further documentation in vtkImageImport.h.
		/// </summary>
		// Token: 0x0200076B RID: 1899
		// (Invoke) Token: 0x06013ABA RID: 80570
		public delegate int PipelineModifiedCallbackType(IntPtr arg0);

		/// <summary>
		/// These are function pointer types for the pipeline connection
		/// callbacks.  See further documentation in vtkImageImport.h.
		/// </summary>
		// Token: 0x0200076C RID: 1900
		// (Invoke) Token: 0x06013ABE RID: 80574
		public delegate void PropagateUpdateExtentCallbackType(IntPtr arg0, IntPtr arg1);

		/// <summary>
		/// These are function pointer types for the pipeline connection
		/// callbacks.  See further documentation in vtkImageImport.h.
		/// </summary>
		// Token: 0x0200076D RID: 1901
		// (Invoke) Token: 0x06013AC2 RID: 80578
		public delegate IntPtr ScalarTypeCallbackType(IntPtr arg0);

		/// <summary>
		/// These are function pointer types for the pipeline connection
		/// callbacks.  See further documentation in vtkImageImport.h.
		/// </summary>
		// Token: 0x0200076E RID: 1902
		// (Invoke) Token: 0x06013AC6 RID: 80582
		public delegate IntPtr SpacingCallbackType(IntPtr arg0);

		/// <summary>
		/// These are function pointer types for the pipeline connection
		/// callbacks.  See further documentation in vtkImageImport.h.
		/// </summary>
		// Token: 0x0200076F RID: 1903
		// (Invoke) Token: 0x06013ACA RID: 80586
		public delegate void UpdateDataCallbackType(IntPtr arg0);

		/// <summary>
		/// These are function pointer types for the pipeline connection
		/// callbacks.  See further documentation in vtkImageImport.h.
		/// </summary>
		// Token: 0x02000770 RID: 1904
		// (Invoke) Token: 0x06013ACE RID: 80590
		public delegate void UpdateInformationCallbackType(IntPtr arg0);

		/// <summary>
		/// These are function pointer types for the pipeline connection
		/// callbacks.  See further documentation in vtkImageImport.h.
		/// </summary>
		// Token: 0x02000771 RID: 1905
		// (Invoke) Token: 0x06013AD2 RID: 80594
		public delegate IntPtr WholeExtentCallbackType(IntPtr arg0);
	}
}
